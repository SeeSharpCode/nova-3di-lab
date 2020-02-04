using Nova3diLab.Utility;
using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class Face : IBinaryFileStructure
    {
        public short Index { get; set; }

        // UV coordinates
        public decimal U1 { get; set; }
        public decimal U2 { get; set; }
        public decimal U3 { get; set; }
        public decimal V1 { get; set; }
        public decimal V2 { get; set; }
        public decimal V3 { get; set; }
        public short Vertex1Index { get; set; }
        public short Vertex2Index { get; set; }
        public short Vertex3Index { get; set; }
        public short Normal1Index { get; set; }
        public short Normal2Index { get; set; }
        public short Normal3Index { get; set; }

        /// <summary>
        /// Negative value of distance from face to zero point.
        /// </summary>
        public decimal Distance { get; set; }

        public decimal XMin { get; set; }
        public decimal XMax { get; set; }
        public decimal YMin { get; set; }
        public decimal YMax { get; set; }
        public decimal ZMin { get; set; }
        public decimal ZMax { get; set; }
        public int MaterialIndex { get; set; }

        public byte[] Serialize()
        {
            using (var buffer = new MemoryStream())
            using (var writer = new BinaryWriter(buffer))
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
                return buffer.ToArray();
            }
        }

        public void Deserialize()
        {
            throw new NotImplementedException();
        }
    }
}