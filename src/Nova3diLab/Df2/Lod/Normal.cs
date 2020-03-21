using System;
using System.IO;

namespace Nova3diLab.Df2.Lod
{
    public class Normal : IModelSerializable
    {
        public Vertex Origin;
        public double Magnitude { get;  }
        public short Shading { get; }

        public Normal(short x, short y, short z, short shading)
        {
            Origin = new Vertex(x, y, z);
            Shading = shading;
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(Origin.X);
            writer.Write(Origin.Y);
            writer.Write(Origin.Z);
            writer.Write(Shading);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}