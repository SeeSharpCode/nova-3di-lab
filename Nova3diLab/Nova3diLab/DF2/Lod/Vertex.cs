using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class Vertex : IBinaryFileStructure
    {
        public ushort X { get; }
        public ushort Y { get; }
        public ushort Z { get; }

        public Vertex(ushort x, ushort y, ushort z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public byte[] Serialize()
        {
            using (MemoryStream buffer = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(buffer))
            {
                writer.Write(X);
                writer.Write(Y);
                writer.Write(Z);
                writer.Write((short)0);
                return buffer.ToArray();
            }
        }

        public void Deserialize()
        {
            throw new NotImplementedException();
        }
    }
}