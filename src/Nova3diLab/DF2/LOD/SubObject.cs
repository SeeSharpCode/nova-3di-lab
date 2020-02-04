using Nova3diLab.Utility;
using System;
using System.IO;

namespace Nova3diLab.Model.Lod
{
    public class SubObject : IBinaryFileStructure
    {
        public int VertexCount { get; set; }
        public int FacesCount { get; set; }
        public int NormalsCount { get; set; }
        public int CollisionVolumesCount { get; set; }
        public decimal XMinimum { get; set; }
        public decimal XMaximum { get; set; }
        public decimal YMinimum { get; set; }
        public decimal YMaximum { get; set; }
        public decimal ZMinimum { get; set; }
        public decimal ZMaximum { get; set; }
        public decimal XMedian { get; set; }
        public decimal YMedian { get; set; }
        public decimal ZMedian { get; set; }
        public decimal SphereRadius { get; set; }
        public decimal CircleRadius { get; set; }
        public decimal ZTotal => ZMaximum - ZMinimum;

        public byte[] Serialize()
        {
            using (var buffer = new MemoryStream())
            using (var writer = new BinaryWriter(buffer))
            {
                writer.Write(0);
                writer.Write(VertexCount);
                writer.Write(0);
                writer.Write(FacesCount);
                writer.Write(0);
                writer.Write(NormalsCount);
                writer.Write(0);
                writer.Write(CollisionVolumesCount);
                writer.Write(0);
                writer.Write(new byte[28]);
                writer.WriteFixedPoint(XMinimum);
                writer.WriteFixedPoint(XMaximum);
                writer.WriteFixedPoint(YMinimum);
                writer.WriteFixedPoint(YMaximum);
                writer.WriteFixedPoint(ZMinimum);
                writer.WriteFixedPoint(ZMaximum);
                writer.WriteFixedPoint(XMedian);
                writer.WriteFixedPoint(YMedian);
                writer.WriteFixedPoint(ZMedian);
                writer.WriteFixedPoint(SphereRadius);
                writer.WriteFixedPoint(CircleRadius);
                writer.WriteFixedPoint(ZTotal);
                return buffer.ToArray();
            }
        }

        public void Deserialize()
        {
            throw new NotImplementedException();
        }
    }
}
