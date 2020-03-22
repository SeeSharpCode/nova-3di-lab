using System;
using System.Collections.Generic;
using System.IO;

namespace Nova3diLab.Df2.Lod
{
    public enum CollisionVolumeType
    {
        Normal = 1,
        Climbable = 4,
        Armory = 6,
        Attachable = 7
    }

    public class CollisionVolume : IModelSerializable
    {
        public CollisionVolumeType VolumeType { get; }
        public List<Vertex> Vertices { get; }
        public double XMedian => (Vertices.GetXMin() + Vertices.GetXMax()) / 2;
        public double YMedian => (Vertices.GetYMin() + Vertices.GetYMax()) / 2;
        public double ZMedian => (Vertices.GetZMin() + Vertices.GetZMax()) / 2;
        public double HalfLength => (Vertices.GetXMax() - Vertices.GetXMin()) / 2;
        public double HalfWidth => (Vertices.GetYMax() - Vertices.GetYMin()) / 2;
        public double HalfHeight => (Vertices.GetZMax() - Vertices.GetZMin()) / 2;
        public int CollisionPlaneCount { get; }

        public CollisionVolume(CollisionVolumeType volumeType, List<Vertex> vertices, int collisionPlaneCount)
        {
            VolumeType = volumeType;
            Vertices = vertices;
            CollisionPlaneCount = collisionPlaneCount;
        }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((int)VolumeType);
            writer.Write(0);
            writer.WriteFixedPoint(XMedian);
            writer.WriteFixedPoint(YMedian);
            writer.WriteFixedPoint(ZMedian);
            writer.WriteFixedPoint(CalculateBoundingSphereRadius());
            writer.WriteFixedPoint(CalculateBoundingCircleRadius());
            writer.WriteFixedPoint(CalculateBoundingCircleRadius());
            writer.WriteFixedPoint(HalfLength);
            writer.WriteFixedPoint(HalfWidth);
            writer.WriteFixedPoint(HalfHeight);
            writer.Write(0);
            writer.WriteFixedPoint(Vertices.GetXMin());
            writer.WriteFixedPoint(Vertices.GetXMax());
            writer.WriteFixedPoint(Vertices.GetYMin());
            writer.WriteFixedPoint(Vertices.GetYMax());
            writer.WriteFixedPoint(Vertices.GetZMin());
            writer.WriteFixedPoint(Vertices.GetZMax());
            writer.Write(CollisionPlaneCount);
            writer.Write(0);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }

        private double CalculateBoundingSphereRadius()
        {
            var xSquared = Math.Pow(HalfLength, 2);
            var ySquared = Math.Pow(HalfWidth, 2);
            var zSquared = Math.Pow(HalfHeight, 2);
            return Math.Sqrt(xSquared + ySquared + zSquared);
        }

        private double CalculateBoundingCircleRadius()
        {
            var xSquared = Math.Pow(HalfLength, 2);
            var ySquared = Math.Pow(HalfWidth, 2);
            return Math.Sqrt(xSquared + ySquared);
        }
    }
}