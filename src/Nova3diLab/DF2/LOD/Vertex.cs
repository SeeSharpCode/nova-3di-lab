using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class Vertex : IModelSerializable
    {
        public short X { get; }
        public short Y { get; }
        public short Z { get; }

        public Vertex(short x, short y, short z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public byte[] Serialize()
        {
            using (var buffer = new MemoryStream())
            using (var writer = new BinaryWriter(buffer))
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