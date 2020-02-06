using Nova3diLab.Utility;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class CollisionVolume : IBinaryFileStructure
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
        public double SphereRadius { get; set; }
        public double CircleRadius { get; set; }
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

        public byte[] Serialize()
        {
            using (var buffer = new MemoryStream())
            using (var writer = new BinaryWriter(buffer))
            {
                writer.Write((int)VolumeType);
                writer.Write(0);
                writer.WriteFixedPoint(XMedian);
                writer.WriteFixedPoint(YMedian);
                writer.WriteFixedPoint(ZMedian);
                writer.WriteFixedPoint(SphereRadius);
                writer.WriteFixedPoint(CircleRadius);
                writer.WriteFixedPoint(CircleRadius);

                return buffer.ToArray();
            }
        }

        public void Deserialize()
        {
            throw new System.NotImplementedException();
        }
    }
}