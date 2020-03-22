using System;
using System.Collections.Generic;
using System.IO;

namespace Nova3diLab.Df2.Lod
{
    public class CollisionPlaneVector : Vector, IModelSerializable
    {
        public short Distance { get; }

        public CollisionPlaneVector(List<Vertex> vertices, short distance)
            : base(vertices)
        {
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