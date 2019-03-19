using System;
using System.IO;

namespace Nova3diLab.Utility
{
    public static class BinaryExtensions
    {
        public static decimal ReadFixedPoint(this BinaryReader binaryReader)
        {
            decimal decimalValue = Math.Round((decimal)binaryReader.ReadInt16() / 65536, 3);
            decimal wholeValue = binaryReader.ReadInt16();
            return wholeValue + decimalValue;
        }

        public static void WriteFixedPoint(this BinaryWriter binaryWriter, decimal value)
        {
            decimal wholePart = Math.Floor(value);
            decimal decimalPart = value < 0 ? (value - wholePart) : (value - Math.Truncate(value));
            binaryWriter.Write((short)(decimalPart * 65536));
            binaryWriter.Write((short)wholePart);
        }
    }
}
