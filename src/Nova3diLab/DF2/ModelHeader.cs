using System;
using System.IO;
using Nova3diLab.Utility;

namespace Nova3diLab.DF2
{
    public class ModelHeader : IModelSerializable
    {
        public string Name { get; set; }
        public int LodCount { get; set; } = 1;
        public int Lod4Distance { get; set; }
        public int Lod3Distance { get; set; }
        public int Lod2Distance { get; set; }
        public int Lod1Distance { get; set; }
        public string RenderType { get; set; } = "crng";
        public double BoundingSphereRadius { get; set; }
        public int TextureCount { get; set; }

        public ModelHeader(string name, double boundingSphereRadius, int textureCount)
        {
            Name = name;
            BoundingSphereRadius = boundingSphereRadius;
            TextureCount = textureCount;
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write("3DI".ToBytes());
            writer.Write((byte)8);
            writer.Write(Name.ToBytes(8));
            writer.Write(0x0012FCD0); // gap
            writer.Write(1);
            writer.Write(LodCount);
            writer.Write(Lod4Distance);
            writer.Write(Lod3Distance);
            writer.Write(Lod2Distance);
            writer.Write(Lod1Distance);

            // LOD render functions
            for (int i = 0; i < 4; i++)
            {
                writer.Write(RenderType.ToBytes());
            }

            writer.Write(new byte[40]); // gap
            writer.WriteFixedPoint(BoundingSphereRadius);
            writer.WriteFixedPoint(BoundingSphereRadius);
            writer.Write(new byte[20]); // gap
            writer.Write(TextureCount);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
