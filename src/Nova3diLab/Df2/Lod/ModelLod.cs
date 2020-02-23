using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nova3diLab.Df2.Lod
{
    public class ModelLod : IModelSerializable
    {
        public LodHeader Header { get; set; }
        public List<Vertex> Vertices { get; set; }
        public List<Normal> Normals { get; set; }
        public List<Face> Faces { get; set; }
        public List<SubObject> SubObjects { get; set; }
        public List<PartAnimation> PartAnimations { get; set; }
        public List<CollisionPlaneVector> CollisionPlaneVectors { get; set; }
        public List<CollisionVolume> CollisionVolumes { get; set; }
        public List<Material> Materials { get; set; }

        public ModelLod(List<Vertex> vertices, List<Face> faces, List<Texture> textures, List<CollisionPlaneVector> collisionPlanes, List<CollisionVolume> collisionVolumes)
        {
            Vertices = vertices;
            Normals = faces.Select(face => face.Normal).ToList();
            Faces = faces;
            SubObjects = new List<SubObject> { new SubObject(vertices, faces.Count, collisionVolumes.Count) };
            CollisionPlaneVectors = collisionPlanes;
            CollisionVolumes = collisionVolumes;
            Materials = textures.Select(texture => new Material(texture)).ToList();            
            Header = new LodHeader(CalculateLength(), vertices, faces.Count, textures.Count, collisionPlanes.Count, collisionVolumes.Count);
        }

        public void Serialize(BinaryWriter writer)
        {
            Header.Serialize(writer);
            Vertices.ForEach(vertex => vertex.Serialize(writer));
            Normals.ForEach(normal => normal.Serialize(writer));
            Faces.ForEach(face => face.Serialize(writer));
            SubObjects.ForEach(subObject => subObject.Serialize(writer));
            PartAnimations?.ForEach(partAnimation => partAnimation.Serialize(writer));
            CollisionPlaneVectors.ForEach(plane => plane.Serialize(writer));
            CollisionVolumes.ForEach(volume => volume.Serialize(writer));
            Materials.ForEach(material => material.Serialize(writer));
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }

        private int CalculateLength()
        {
            using (MemoryStream buffer = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(buffer))
            {
                Vertices.ForEach(vertex => vertex.Serialize(writer));
                Normals.ForEach(normal => normal.Serialize(writer));
                Faces.ForEach(face => face.Serialize(writer));
                SubObjects.ForEach(subObject => subObject.Serialize(writer));
                CollisionPlaneVectors.ForEach(collisionPlane => collisionPlane.Serialize(writer));
                CollisionVolumes.ForEach(collisionVolume => collisionVolume.Serialize(writer));
                Materials.ForEach(material => material.Serialize(writer));
                
                return (int)buffer.Length;
            }
        }
    }
}
