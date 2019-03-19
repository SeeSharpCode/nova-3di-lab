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
    }
}
