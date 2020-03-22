using System;
using System.IO;

namespace Nova3diLab.Df2.Lod
{
    public enum MaterialType
    {
        Cloth,
        Glass,
        ThickMetal,
        ThinMetal,
        Sand,
        Stone,
        Straw,
        Vapor,
        Wood
    }

    public class Material : IModelSerializable
    {
        public string Name { get; }
        public byte SidesVisible { get; } = 1;
        public bool IsTransparent { get; }
        public MaterialType MaterialType { get; } = MaterialType.Stone;
        public bool IsAnimated { get; }
        public byte GreenBitmapIndex { get; }
        public byte BrownBitmapIndex { get; }
        public byte WhiteBitmapIndex { get; }
        public byte AlphaBitmapIndex { get; }
        public bool IsGlowing { get; }

        public Material(Texture texture)
        {
            Name = texture.Name;
            GreenBitmapIndex = (byte)texture.Index;
            BrownBitmapIndex = (byte)texture.Index;
            WhiteBitmapIndex = (byte)texture.Index;
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(Name.ToBytes(16));
            writer.Write(SidesVisible);
            // TODO transparency logic
            writer.Write((byte)0);
            // TODO material type
            writer.Write((short)4);
            writer.Write(new byte[11]);
            writer.Write(IsAnimated ? (byte)1 : (byte)0);
            writer.Write(new byte[20]);
            writer.Write(GreenBitmapIndex);
            writer.Write(BrownBitmapIndex);
            writer.Write(WhiteBitmapIndex);
            writer.Write(AlphaBitmapIndex);
            writer.Write(new byte[6]);
            writer.Write(IsGlowing ? (byte)1 : (byte)0);
            writer.Write(new byte[57]);
            
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}