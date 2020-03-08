using System;
using System.IO;

namespace Nova3diLab.Df2
{
    public class Texture : IModelSerializable
    {
        public string Name { get; set; }
        public string TransparentName { get; set; }
        public int Size => Width * Height;
        public short Index { get; set; }
        public bool IsLightOn { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }

        public Texture(string name, short index, short width, short height)
        {
            Name = name;
            Index = index;
            Width = width;
            Height = height;
        }

        public void Serialize(BinaryWriter writer)
        {
            // Texture header
            // TODO: Split into Name and TransparentName.
            writer.Write(Name.ToBytes(28));
            writer.Write(Size);
            writer.Write(Index);
            writer.Write((short)(IsLightOn ? 0x1F : 7));
            writer.Write(Width);
            writer.Write(Height);
            writer.Write(new byte[12]);

            // TODO data
            writer.Write(new byte[Width * Height]);
            // TODO palette
            writer.Write(new byte[1024]);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
