using Nova3diLab.Utility;
using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class LodHeader : IModelSerializable
    {
        public int Length { get; set; }
        public double BoundingSphereRadius { get; set; }
        public double ZTotal { get; set; }
        public double XMin { get; set; }
        public double XMax { get; set; }
        public double YMin { get; set; }
        public double YMax { get; set; }
        public double ZMin { get; set; }
        public double ZMax { get; set; }
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

        public void Serialize(BinaryWriter writer)
        {
            writer.Write(new byte[20]); // TODO NovalogicTools defines some other structures here.
            writer.Write(Length);
            writer.Write(0);
            writer.WriteFixedPoint(BoundingSphereRadius);
            writer.WriteFixedPoint(BoundingSphereRadius);
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
        }

        public void Deserialize(BinaryReader reader)
        {
            throw new NotImplementedException();
        }
    }
}