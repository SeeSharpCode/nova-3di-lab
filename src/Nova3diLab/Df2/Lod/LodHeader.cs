using System;
using System.Collections.Generic;
using System.IO;

namespace Nova3diLab.Df2.Lod
{
    public class LodHeader : IModelSerializable
    {
        private List<Vertex> _vertices;

        public int Length { get; }
        public int LoopImageCount { get; }
        public int LoopInterval { get; }
        public int FaceCount { get; }
        public int SubObjectCount { get; } = 1;
        public int PartAnimCount { get; }
        public int MaterialCount { get; }
        public int CollisionPlaneCount { get; }
        public int CollisionVolumeCount { get; }

        public LodHeader(int length, List<Vertex> vertices, int faceCount, int materialCount, int collisionPlaneCount, int collisionVolumeCount)
        {
            Length = length;
            _vertices = vertices;
            FaceCount = faceCount;
            MaterialCount = materialCount;
            CollisionPlaneCount = collisionPlaneCount;
            CollisionVolumeCount = collisionVolumeCount;
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(new byte[20]); // TODO NovalogicTools defines some other structures here.
            writer.Write(Length);
            writer.Write(0);
            writer.WriteFixedPoint(_vertices.CalculateBoundingSphereRadius());
            writer.WriteFixedPoint(_vertices.CalculateBoundingSphereRadius());
            writer.WriteFixedPoint(_vertices.GetZLength());
            writer.WriteFixedPoint(_vertices.GetXMin());
            writer.WriteFixedPoint(_vertices.GetXMax());
            writer.WriteFixedPoint(_vertices.GetYMin());
            writer.WriteFixedPoint(_vertices.GetYMax());
            writer.WriteFixedPoint(_vertices.GetZMin());
            writer.WriteFixedPoint(_vertices.GetZMax());
            writer.Write(LoopImageCount);
            writer.Write(new byte[20]);
            writer.Write(LoopInterval);
            writer.Write(new byte[36]);
            writer.Write(_vertices.Count);
            writer.Write(0);
            writer.Write(FaceCount);
            writer.Write(0);
            writer.Write(FaceCount);
            writer.Write(0);
            writer.Write(SubObjectCount);
            writer.Write(0);
            writer.Write(PartAnimCount);
            writer.Write(0);
            writer.Write(MaterialCount);
            writer.Write(0);
            writer.Write(CollisionPlaneCount);
            writer.Write(0);
            writer.Write(CollisionVolumeCount);
            writer.Write(0);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}