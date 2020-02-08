using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class Material : IModelSerializable
    {
        public string Name { get; set; }
        public byte Type1 { get; set; } // TODO: enum
        public byte Type2 { get; set; } // TODO: enum
        public byte Type3 { get; set; } // TODO: enum
        public byte Type4 { get; set; } // TODO: enum
        public byte GreenBitmapIndex { get; set; }
        public byte BrownBitmapIndex { get; set; }
        public byte WhiteBitmapIndex { get; set; }
        public byte AnimationFrameSequenceNumber { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}