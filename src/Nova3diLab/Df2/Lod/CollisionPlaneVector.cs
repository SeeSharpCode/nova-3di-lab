using System;
using System.IO;

namespace Nova3diLab.Df2.Lod
{
    public class CollisionPlaneVector : IModelSerializable
    {
        public Vertex Origin { get; }
        public short Distance { get; }

        public CollisionPlaneVector(short x, short y, short z, short distance)
        {
            Origin = new Vertex(x, y, z);
            Distance = distance;
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(Origin.X);
            writer.Write(Origin.Y);
            writer.Write(Origin.Z);
            writer.Write(Distance);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}