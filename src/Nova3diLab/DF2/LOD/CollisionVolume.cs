using Nova3diLab.Utility;
using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    // TODO finish structure and test
    public class CollisionVolume : IModelSerializable
    {
        public enum CollisionVolumeType
        {
            Normal = 1,
            Climbable = 4,
            Armory = 6,
            Attachable = 7
        }

        public CollisionVolumeType VolumeType { get; set; }
        public double XMedian => (XMin + XMax) / 2;
        public double YMedian => (YMin + YMax) / 2;
        public double ZMedian => (ZMin + ZMax) / 2;
        public double BoundingSphereRadius { get; set; }
        public double XTotal { get; set; }
        public double YTotal { get; set; }
        public double ZTotal { get; set; }
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
            writer.WriteFixedPoint(BoundingSphereRadius);
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}