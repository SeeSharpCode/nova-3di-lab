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
        public decimal XMedian => (XMin + XMax) / 2;
        public decimal YMedian => (YMin + YMax) / 2;
        public decimal ZMedian => (ZMin + ZMax) / 2;
        public decimal SphereRadius { get; set; }
        public decimal CircleRadius { get; set; }
        public decimal XTotal { get; set; }
        public decimal YTotal { get; set; }
        public decimal ZTotal { get; set; }
        public decimal XMin { get; set; }
        public decimal XMax { get; set; }
        public decimal YMin { get; set; }
        public decimal YMax { get; set; }
        public decimal ZMin { get; set; }
        public decimal ZMax { get; set; }
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