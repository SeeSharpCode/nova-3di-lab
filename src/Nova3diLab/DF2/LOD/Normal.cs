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

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
            writer.Write(W);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}