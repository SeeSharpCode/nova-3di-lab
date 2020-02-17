using Nova3diLab.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nova3diLab.Model.Lod
{
    public class Face : IModelSerializable
    {
        public short Index { get; set; }
        public List<Tuple<double, double>> UVCoordinates;
        public List<Tuple<int, Vertex>> IndexedVertices { get; set; }
        public List<Vertex> Vertices => IndexedVertices.Select(vertex => vertex.Item2).ToList();
        public int MaterialIndex { get; set; }

        public Face(short index, List<Tuple<double, double>> uvCoordinates, List<Tuple<int, Vertex>> indexedVertices, int materialIndex)
        {
            Index = index;
            UVCoordinates = uvCoordinates;
            IndexedVertices = indexedVertices;
            MaterialIndex = materialIndex;
        }

        private double CalculateDistance()
        {
            return ((-Vertices[0].X * (Vertices[1].Y * Vertices[2].Z - Vertices[2].Y * Vertices[1].Z)
                   - Vertices[1].X * (Vertices[2].Y * Vertices[0].Z - Vertices[0].Y * Vertices[2].Z)
                   - Vertices[2].X * (Vertices[0].Y * Vertices[1].Z - Vertices[1].Y * Vertices[0].Z)) / 65536) / 256;
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
            var distance = CalculateDistance();
            writer.WriteFixedPoint(CalculateDistance());
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
    }
}