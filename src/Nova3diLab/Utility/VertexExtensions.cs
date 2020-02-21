using System;
using System.Collections.Generic;
using System.Linq;
using Nova3diLab.Df2.Lod;

namespace Nova3diLab.Utility
{
    public static class VertexExtensions
    {
        public static double GetXMin(this List<Vertex> vertices)
        {
            return Math.Round((double)vertices.Select(vertex => vertex.X).Min() / 256, 3);
        }

        public static double GetXMax(this List<Vertex> vertices)
        {
            return Math.Round((double)vertices.Select(vertex => vertex.X).Max() / 256, 3);
        }

        public static double GetYMin(this List<Vertex> vertices)
        {
            return Math.Round((double)vertices.Select(vertex => vertex.Y).Min() / 256, 3);
        }

        public static double GetYMax(this List<Vertex> vertices)
        {
            return Math.Round((double)vertices.Select(vertex => vertex.Y).Max() / 256, 3);
        }

        public static double GetZMin(this List<Vertex> vertices)
        {
            return Math.Round((double)vertices.Select(vertex => vertex.Z).Min() / 256, 3);
        }

        public static double GetZMax(this List<Vertex> vertices)
        {
            return Math.Round((double)vertices.Select(vertex => vertex.Z).Max() / 256, 3);
        }

        public static double GetXMedian(this List<Vertex> vertices)
        {
            return Math.Round((vertices.GetXMin() + vertices.GetXMax() / 2), 3);
        }

        public static double GetYMedian(this List<Vertex> vertices)
        {
            return Math.Round((vertices.GetYMin() + vertices.GetYMax() / 2), 3);
        }

        public static double GetZMedian(this List<Vertex> vertices)
        {
            return Math.Round((vertices.GetZMin() + vertices.GetZMax() / 2), 3);
        }

        public static double GetZLength(this List<Vertex> vertices)
        {
            return Math.Round(vertices.GetZMax() - vertices.GetZMin(), 3);
        }

        public static double CalculateBoundingSphereRadius(this List<Vertex> vertices)        
        {
            var xMaxAbsolute = Math.Max(Math.Abs(vertices.GetXMin()), Math.Abs(vertices.GetXMax()));
            var yMaxAbsolute = Math.Max(Math.Abs(vertices.GetYMin()), Math.Abs(vertices.GetYMax()));
            var zMaxAbsolute = Math.Max(Math.Abs(vertices.GetZMin()), Math.Abs(vertices.GetZMax()));

            var maxSumSquared = Math.Pow(xMaxAbsolute, 2) + Math.Pow(yMaxAbsolute, 2) + Math.Pow(zMaxAbsolute, 2);

            return Math.Sqrt(maxSumSquared);
        }
    }
}