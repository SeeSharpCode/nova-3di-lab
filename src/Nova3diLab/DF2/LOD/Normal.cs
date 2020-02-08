using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class Normal : IModelSerializable
    {
        public short X { get; }
        public short Y { get; }
        public short Z { get; }
        public short W { get; }

        public Normal(short x, short y, short z, short w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public byte[] Serialize()
        {
            using (var buffer = new MemoryStream())
            using (var writer = new BinaryWriter(buffer))
            {
                writer.Write(X);
                writer.Write(Y);
                writer.Write(Z);
                writer.Write(W);
                return buffer.ToArray();
            }
        }

        public void Deserialize()
        {
            throw new NotImplementedException();
        }
    }
}