using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nova3diLab.Model.Lod
{
    // TODO test
    public class   ModelLod : IModelSerializable
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

        public double XMin => Math.Round((double)Vertices.Select(vertex => (short)vertex.X).Min() / 256, 3);
        public double XMax => Math.Round((double)Vertices.Select(vertex => (short)vertex.X).Max() / 256, 3);
        public double YMin => Math.Round((double)Vertices.Select(vertex => (short)vertex.Y).Min() / 256, 3);
        public double YMax => Math.Round((double)Vertices.Select(vertex => (short)vertex.Y).Max() / 256, 3);
        public double ZMin => Math.Round((double)Vertices.Select(vertex => (short)vertex.Z).Min() / 256, 3);
        public double ZMax => Math.Round((double)Vertices.Select(vertex => (short)vertex.Z).Max() / 256, 3);
        
        public double CalcuateBoundingSphereRadius()
        {
            var xMaxAbsolute = Math.Max(Math.Abs(XMin), Math.Abs(XMax));
            var yMaxAbsolute = Math.Max(Math.Abs(YMin), Math.Abs(YMax));
            var zMaxAbsolute = Math.Max(Math.Abs(ZMin), Math.Abs(ZMax));

            var maxSumSquared = Math.Pow(xMaxAbsolute, 2) + Math.Pow(yMaxAbsolute, 2) + Math.Pow(zMaxAbsolute, 2);

            return Math.Sqrt(maxSumSquared);
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
