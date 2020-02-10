using System;
using System.Collections.Generic;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class Normal : IModelSerializable
    {
        public short X { get; }
        public short Y { get; }
        public short Z { get; }
        public short W { get; }

        public Normal(Face face, List<Vertex> vertices)
        {
            var x = (
                (vertices[face.Vertex2Index].Y - vertices[face.Vertex1Index].Y) * (vertices[face.Vertex3Index].Z - vertices[face.Vertex1Index].Z)
                - ((vertices[face.Vertex3Index].Y - vertices[face.Vertex1Index].Y) * (vertices[face.Vertex2Index].Z - vertices[face.Vertex1Index].Z))
            );
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(X);
            writer.Write(Y);
            writer.Write(Z);
            writer.Write(W);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}