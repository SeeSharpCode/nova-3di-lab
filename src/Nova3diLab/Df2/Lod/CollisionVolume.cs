using System;
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
        public CollisionVolumeType VolumeType { get; set; }
        public double XMedian => (XMin + XMax) / 2;
        public double YMedian => (YMin + YMax) / 2;
        public double ZMedian => (ZMin + ZMax) / 2;
        public double BoundingSphereRadius { get; set; }
        public double BoundingCircleRadius { get; set; }
        public double HalfLength => (XMax - XMin) / 2;
        public double HalfWidth => (YMax - YMin) / 2;
        public double HalfHeight => (ZMax - ZMin) / 2;
        public double XMin { get; set; }
        public double XMax { get; set; }
        public double YMin { get; set; }
        public double YMax { get; set; }
        public double ZMin { get; set; }
        public double ZMax { get; set; }
        public int CollisionPlaneCount { get; set; }

        public void Serialize(BinaryWriter writer)
        {
            writer.Write((int)VolumeType);
            writer.Write(0);
            writer.WriteFixedPoint(XMedian);
            writer.WriteFixedPoint(YMedian);
            writer.WriteFixedPoint(ZMedian);
            writer.WriteFixedPoint(BoundingSphereRadius);
            writer.WriteFixedPoint(BoundingCircleRadius);
            writer.WriteFixedPoint(BoundingCircleRadius);
            writer.WriteFixedPoint(HalfLength);
            writer.WriteFixedPoint(HalfWidth);
            writer.WriteFixedPoint(HalfHeight);
            writer.Write(0);
            writer.WriteFixedPoint(XMin);
            writer.WriteFixedPoint(XMax);
            writer.WriteFixedPoint(YMin);
            writer.WriteFixedPoint(YMax);
            writer.WriteFixedPoint(ZMin);
            writer.WriteFixedPoint(ZMax);
            writer.Write(CollisionPlaneCount);
            writer.Write(0);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}