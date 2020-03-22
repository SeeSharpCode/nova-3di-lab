using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nova3diLab.Df2.Lod
{
    public class Normal : Vector, IModelSerializable
    {
        public short Shading { get; }

        public Normal(List<Vertex> vertices)
            : base(vertices)
        {
            var absoluteMax = new List<short>() { Math.Abs(Origin.X), Math.Abs(Origin.Y), Math.Abs(Origin.Z) }.Max();
            var shading = (short)(absoluteMax == Math.Abs(Origin.X) ? 4 : (absoluteMax == Math.Abs(Origin.Y)) ? 2 : 1);
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