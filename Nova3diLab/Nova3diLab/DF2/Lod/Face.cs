using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class Face : IBinaryFileStructure
    {
        public short Index { get; set; }

        // UV coordinates
        public uint U1 { get; set; }
        public int U2 { get; set; }
        public int U3 { get; set; }
        public int V1 { get; set; }
        public int V2 { get; set; }
        public int V3 { get; set; }
        public short Vertex1Index { get; set; }
        public short Vertex2Index { get; set; }
        public short Vertex3Index { get; set; }
        public short Normal1Index { get; set; }
        public short Normal2Index { get; set; }
        public short Normal3Index { get; set; }

        /// <summary>
        /// Negative value of distance from face to zero point.
        /// </summary>
        public int Distance { get; set; }

        public int XMin { get; set; }
        public int XMax { get; set; }
        public int YMin { get; set; }
        public int YMax { get; set; }
        public int ZMin { get; set; }
        public int ZMax { get; set; }
        public int MaterialIndex { get; set; }

        public byte[] Serialize()
        {
            using (MemoryStream buffer = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(buffer))
            {
                writer.Write((short)0);
                writer.Write(Index);
                writer.Write(U1);
                writer.Write(U2);
                writer.Write(U3);
                writer.Write(V1);
                writer.Write(V2);
                writer.Write(V3);
                writer.Write(Vertex1Index);
                writer.Write(Vertex2Index);
                writer.Write(Vertex3Index);
                writer.Write(Normal1Index);
                writer.Write(Normal2Index);
                writer.Write(Normal3Index);
                writer.Write(Distance);
                writer.Write(XMin);
                writer.Write(XMax);
                writer.Write(YMin);
                writer.Write(YMax);
                writer.Write(ZMin);
                writer.Write(ZMax);
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