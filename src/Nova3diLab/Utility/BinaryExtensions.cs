using System;
using System.IO;

namespace Nova3diLab.Utility
{
    public static class BinaryExtensions
    {
        public static double ReadFixedPoint(this BinaryReader binaryReader)
        {
            var decimalValue = Math.Round((double)binaryReader.ReadInt16() / 65536, 3);
            var wholeValue = binaryReader.ReadInt16();
            return wholeValue + decimalValue;
        }

        public static void WriteFixedPoint(this BinaryWriter binaryWriter, double value)
        {
            var wholePart = Math.Floor(value);
            var decimalPart = value < 0 ? (value - wholePart) : (value - Math.Truncate(value));
            binaryWriter.Write((ushort)(decimalPart * 65536));
            binaryWriter.Write((short)wholePart);
        }
    }
}
