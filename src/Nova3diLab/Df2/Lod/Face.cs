using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nova3diLab.Df2.Lod
{
    public class Face : IModelSerializable
    {
        private double magnitude;

        public short Index { get; set; }
        public List<Tuple<double, double>> UVCoordinates;
        public List<Tuple<int, Vertex>> IndexedVertices { get; set; }
        public List<Vertex> Vertices => IndexedVertices.Select(vertex => vertex.Item2).ToList();
        public int MaterialIndex { get; set; }
        public Normal Normal { get; set; }
        public CollisionPlaneVector CollisionPlaneVector { get; set; }

        public Face(short index, List<Tuple<double, double>> uvCoordinates, List<Tuple<int, Vertex>> indexedVertices, int materialIndex)
        {
            Index = index;
            UVCoordinates = uvCoordinates;
            IndexedVertices = indexedVertices;
            MaterialIndex = materialIndex;
            CalculateVectors();
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((short)0);
            writer.Write(Index);
            UVCoordinates.ForEach(coordinate => writer.WriteFixedPoint(coordinate.Item1)); // U
            UVCoordinates.ForEach(coordinate => writer.WriteFixedPoint(coordinate.Item2)); // V
            IndexedVertices.ForEach(vertex => writer.Write((short)vertex.Item1));
            writer.Write(Index);
            writer.Write(Index);
            writer.Write(Index);
            writer.WriteFixedPoint(CalculateDistance() / 256);
            writer.WriteFixedPoint(Vertices.GetXMin());
            writer.WriteFixedPoint(Vertices.GetXMax());
            writer.WriteFixedPoint(Vertices.GetYMin());
            writer.WriteFixedPoint(Vertices.GetYMax());
            writer.WriteFixedPoint(Vertices.GetZMin());
            writer.WriteFixedPoint(Vertices.GetZMax());
            writer.Write(MaterialIndex);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }

        private void CalculateVectors()
        {
            var Ax = Vertices[1].X - Vertices[0].X;
            var Bx = Vertices[2].X - Vertices[0].X;

            var Ay = Vertices[1].Y - Vertices[0].Y;
            var By = (Vertices[2].Y - Vertices[0].Y);
            
            var Az = Vertices[1].Z - Vertices[0].Z;
            var Bz = (Vertices[2].Z - Vertices[0].Z);

            var Nx = (Ay * Bz) - (By * Az);
            var Ny = (Az * Bx) - (Bz * Ax);
            var Nz = (Ax * By) - (Bx * Ay);

            magnitude = Math.Sqrt(Math.Pow(Nx, 2) + Math.Pow(Ny, 2) + Math.Pow(Nz, 2));

            var x = (short)((Nx / magnitude) * 16384);
            var y = (short)((Ny / magnitude) * 16384);
            var z = (short)((Nz / magnitude) * 16384);

            var absoluteMax = new List<short>() { Math.Abs(x), Math.Abs(y), Math.Abs(z) }.Max();

            var shading = (short)(absoluteMax == Math.Abs(x) ? 4 : (absoluteMax == Math.Abs(y)) ? 2 : 1);

            Normal = new Normal(x, y, z, shading);
            CollisionPlaneVector = new CollisionPlaneVector(x, y, z, (short)CalculateDistance());
        }

        private double CalculateDistance()
        {
            return (-Vertices[0].X * (Vertices[1].Y * Vertices[2].Z - Vertices[2].Y * Vertices[1].Z)
                   - Vertices[1].X * (Vertices[2].Y * Vertices[0].Z - Vertices[0].Y * Vertices[2].Z)
                   - Vertices[2].X * (Vertices[0].Y * Vertices[1].Z - Vertices[1].Y * Vertices[0].Z)) / magnitude;
        }
    }
}
