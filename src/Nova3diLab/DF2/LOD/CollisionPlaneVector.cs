using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class CollisionPlaneVector : IModelSerializable
    {
        public short X { get; set; }
        public short Z { get; set; }
        public short Y { get; set; }
        public short Distance { get; set; }

        public CollisionPlaneVector(short x, short y, short z, short distance)
        {
            X = x;
            Y = y;
            Z = z;
            Distance = distance;
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
            writer.Write(Distance);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}