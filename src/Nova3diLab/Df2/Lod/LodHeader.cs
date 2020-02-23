using Nova3diLab.Utility;
using System;
using System.Collections.Generic;
using System.IO;

namespace Nova3diLab.Df2.Lod
{
    public class LodHeader : IModelSerializable
    {
        private List<Vertex> _vertices;

        public int Length { get; set; }
        public int LoopImageCount { get; set; }
        public int LoopInterval { get; set; }
        public int FaceCount { get; set; }
        public int SubObjectCount { get; set; } = 1;
        public int PartAnimCount { get; set; }
        public int MaterialCount { get; set; }
        public int CollisionPlaneCount { get; set; }
        public int CollisionVolumeCount { get; set; }

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