using System;
using System.IO;

namespace Nova3diLab.Df2.Lod
{
    public class Normal : IModelSerializable
    {
        public short X { get; }
        public short Y { get; }
        public short Z { get; }
        public short Shading { get; }

        public Normal(short x, short y, short z, short shading)
        {
            X = x;
            Y = y;
            Z = z;
            Shading = shading;
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
            writer.Write(Shading);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}