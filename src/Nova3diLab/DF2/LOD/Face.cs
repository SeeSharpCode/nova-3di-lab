using Nova3diLab.Utility;
using System;
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
        public short Vertex1Index { get; set; }
        public short Vertex2Index { get; set; }
        public short Vertex3Index { get; set; }
        public short Normal1Index { get; set; }
        public short Normal2Index { get; set; }
        public short Normal3Index { get; set; }

        /// <summary>
        /// Negative value of distance from face to zero point.
        /// </summary>
        public double Distance { get; set; }

        public double XMin { get; set; }
        public double XMax { get; set; }
        public double YMin { get; set; }
        public double YMax { get; set; }
        public double ZMin { get; set; }
        public double ZMax { get; set; }
        public int MaterialIndex { get; set; }

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
            writer.Write(Vertex1Index);
            writer.Write(Vertex2Index);
            writer.Write(Vertex3Index);
            writer.Write(Normal1Index);
            writer.Write(Normal2Index);
            writer.Write(Normal3Index);
            writer.WriteFixedPoint(Distance);
            writer.WriteFixedPoint(XMin);
            writer.WriteFixedPoint(XMax);
            writer.WriteFixedPoint(YMin);
            writer.WriteFixedPoint(YMax);
            writer.WriteFixedPoint(ZMin);
            writer.WriteFixedPoint(ZMax);
            writer.Write(MaterialIndex);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}