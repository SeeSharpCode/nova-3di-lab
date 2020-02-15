using Nova3diLab.Utility;
using System;
using System.Collections.Generic;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class Face : IModelSerializable
    {
        public short Index { get; set; }

        // UV coordinates
        public double U1 { get; set; }
        public double U2 { get; set; }
        public double U3 { get; set; }
        public double V1 { get; set; }
        public double V2 { get; set; }
        public double V3 { get; set; }

        public List<Vertex> Vertices { get; set; }

        public int MaterialIndex { get; set; }

        public Face(short index, double u1, double u2, double u3, double v1, double v2, double v3, List<Vertex> vertices, int materialIndex)
        {
            Index = index;
            U1 = u1;
            U2 = u2;
            U3 = u3;
            V1 = v1;
            V2 = v2;
            V3 = v3;
            Vertices = vertices;
            MaterialIndex = materialIndex;
        }

        private double CalculateDistance()
        {
           return (-Vertices[0].X * (Vertices[1].Y * Vertices[2].Z - Vertices[2].Y * Vertices[1].Z) 
                  - Vertices[1].X * (Vertices[2].Y * Vertices[0].Z - Vertices[0].Y * Vertices[2].Z)
                  - Vertices[2].X * (Vertices[0].Y * Vertices[1].Z - Vertices[1].Y * Vertices[0].Z));
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((short)0);
            writer.Write(Index);
            writer.WriteFixedPoint(U1);
            writer.WriteFixedPoint(U2);
            writer.WriteFixedPoint(U3);
            writer.WriteFixedPoint(V1);
            writer.WriteFixedPoint(V2);
            writer.WriteFixedPoint(V3);
            Vertices.ForEach(vertex => writer.Write(vertex.Index));
            writer.Write(Index);
            writer.Write(Index);
            writer.Write(Index);
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