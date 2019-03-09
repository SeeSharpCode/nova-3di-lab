using Nova3diLab.Utility;
using System.IO;

namespace Nova3diLab.DF2
{
    public class Texture : IBinaryFileStructure
    {
        public string Name { get; set; }
        public string TransparentName { get; set; }
        public int Size => Width * Height;
        public short Index { get; set; }
        public bool IsLightOn { get; set; }
        public short Width { get; set; }
        public short Height { get; set; }
        public byte[] Data { get; set; }
        public byte[] Palette { get; set; }
        
        public byte[] Serialize()
        {
            using (MemoryStream buffer = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(buffer))
            {
                // TODO: Split into Name and TransparentName.
                writer.Write(Name.ToBytes(28));
                writer.Write(Size);
                writer.Write(Index);
                writer.Write((short)(IsLightOn ? 0x1F : 7));
                writer.Write(Width);
                writer.Write(Height);
                writer.Write(new byte[12]);
                writer.Write(new byte[Width * Height]);
                writer.Write(new byte[1024]);
                return buffer.ToArray();
            }
        }

        public void Deserialize()
        {
            throw new System.NotImplementedException();
        }
    }
}
