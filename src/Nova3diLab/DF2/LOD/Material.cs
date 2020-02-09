using System;
using System.IO;
using Nova3diLab.DF2;
using Nova3diLab.Utility;

namespace Nova3diLab.Model.Lod
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
        public string Name { get; set; }
        public byte SidesVisible { get; set; } = 1;
        public bool IsTransparent { get; set; }
        public MaterialType MaterialType { get; set; } = MaterialType.Stone;
        public bool IsAnimated { get; set; }
        public byte GreenBitmapIndex { get; set; }
        public byte BrownBitmapIndex { get; set; }
        public byte WhiteBitmapIndex { get; set; }
        public byte AlphaBitmapIndex { get; set; }
        public bool IsGlowing { get; set; }

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