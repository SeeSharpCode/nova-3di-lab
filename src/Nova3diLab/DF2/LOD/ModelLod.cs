using System;
using System.Collections.Generic;
using System.Linq;

namespace Nova3diLab.Model.Lod
{
    public class ModelLod
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

        public ModelLod()
        {
            Header = new LodHeader
            {
                Length = Vertices.SelectMany(vertex => vertex.Serialize()).Count()
                         + Normals.SelectMany(normal => normal.Serialize()).Count()
                         + Faces.SelectMany(face => face.Serialize()).Count()
                         + SubObjects.SelectMany(subObject => subObject.Serialize()).Count()
                         + CollisionPlaneVectors.SelectMany(collisionPlane => collisionPlane.Serialize()).Count()
                         + CollisionVolumes.SelectMany(collisionVolume => collisionVolume.Serialize()).Count()
                         + Materials.SelectMany(material => material.Serialize()).Count()
            };
        }
        
        public double CalcuateBoundingSphereRadius()
        {
            var xMaxAbsolute = Math.Max(Math.Abs(XMin), Math.Abs(XMax));
            var yMaxAbsolute = Math.Max(Math.Abs(YMin), Math.Abs(YMax));
            var zMaxAbsolute = Math.Max(Math.Abs(ZMin), Math.Abs(ZMax));

            var maxSumSquared = Math.Pow(xMaxAbsolute, 2) + Math.Pow(yMaxAbsolute, 2) + Math.Pow(zMaxAbsolute, 2);

            return Math.Sqrt(maxSumSquared);
        }
    }
}
