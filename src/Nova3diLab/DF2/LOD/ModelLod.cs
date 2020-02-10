using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nova3diLab.DF2;

namespace Nova3diLab.Model.Lod
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

        public ModelLod(List<Vertex> vertices, List<Face> faces, List<Texture> textures)
        {
            Header = new LodHeader(vertices, faces.Count, textures.Count);
            Vertices = vertices;
            // TODO normals
            Faces = faces;
            SubObjects = new List<SubObject> { new SubObject(vertices, faces.Count, 0) }; // TODO collision counts
            // TODO collision
            Materials = textures.Select(texture => new Material(texture)).ToList();
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
    }
}
