using Nova3diLab.Utility;
using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class LodHeader : IBinaryFileStructure
    {
        public int Length { get; set; }
        public decimal SphereRadius { get; set; }
        public decimal CircleRadius { get; set; }
        public decimal ZTotal { get; set; }
        public decimal XMin { get; set; }
        public decimal XMax { get; set; }
        public decimal YMin { get; set; }
        public decimal YMax { get; set; }
        public decimal ZMin { get; set; }
        public decimal ZMax { get; set; }
        public int LoopImageCount { get; set; }
        public int LoopInterval { get; set; }
        public int VertexCount { get; set; }
        public int NormalCount { get; set; }
        public int FaceCount { get; set; }
        public int SubObjectCount { get; set; }
        public int PartAnimCount { get; set; }
        public int MaterialCount { get; set; }
        public int CollisionPlaneCount { get; set; }
        public int CollisionVolumeCount { get; set; }

        public byte[] Serialize()
        {
            using (MemoryStream buffer = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(buffer))
            {
                writer.Write(new byte[20]); // ODO NovalogicTools defines some other structures here.
                writer.Write(Length);
                writer.Write(0);
                writer.WriteFixedPoint(SphereRadius);
                writer.WriteFixedPoint(CircleRadius);
                writer.WriteFixedPoint(ZTotal);
                writer.WriteFixedPoint(XMin);
                writer.WriteFixedPoint(XMax);
                writer.WriteFixedPoint(YMin);
                writer.WriteFixedPoint(YMax);
                writer.WriteFixedPoint(ZMin);
                writer.WriteFixedPoint(ZMax);
                writer.Write(LoopImageCount);
                writer.Write(new byte[20]);
                writer.Write(LoopInterval);
                writer.Write(new byte[36]);
                writer.Write(VertexCount);
                writer.Write(0);
                writer.Write(NormalCount);
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
                return buffer.ToArray();
            }
        }

        public void Deserialize()
        {
            throw new NotImplementedException();
        }
    }
}