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

        internal double GetXMin()
        {
            return Math.Round((double)Vertices.Select(vertex => (short)vertex.X).Min() / 256, 3);
        }

        internal double GetYMin()
        {
            return Math.Round((double)Vertices.Select(vertex => (short)vertex.Y).Min() / 256, 3);
        }

        internal double GetZMin()
        {
            return Math.Round((double)Vertices.Select(vertex => (short)vertex.Z).Min() / 256, 3);
        }

        internal double GetXMax()
        {
            return Math.Round((double)Vertices.Select(vertex => (short)vertex.X).Max() / 256, 3);
        }

        internal double GetYMax()
        {
            return Math.Round((double)Vertices.Select(vertex => (short)vertex.Y).Max() / 256, 3);
        }

        internal double GetZMax()
        {
            return Math.Round((double)Vertices.Select(vertex => (short)vertex.Z).Max() / 256, 3);
        }

        internal int CalcuateRadius()
        {
            double xMaxAbsolute = Math.Max(Math.Abs(GetXMin()), Math.Abs(GetXMax()));
            double yMaxAbsolute = Math.Max(Math.Abs(GetYMin()), Math.Abs(GetYMax()));
            double zMaxAbsolute = Math.Max(Math.Abs(GetZMin()), Math.Abs(GetZMax()));

            double maxSumSquared = Math.Pow(xMaxAbsolute, 2) + Math.Pow(yMaxAbsolute, 2) + Math.Pow(zMaxAbsolute, 2);

            return (int)(Math.Sqrt(maxSumSquared) * 65536);
        }
    }
}
