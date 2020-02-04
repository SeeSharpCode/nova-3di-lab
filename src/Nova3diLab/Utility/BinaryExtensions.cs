using System;
using System.IO;

namespace Nova3diLab.Utility
{
    public static class BinaryExtensions
    {
        public static decimal ReadFixedPoint(this BinaryReader binaryReader)
        {
            var decimalValue = (decimal)binaryReader.ReadInt16() / 65536;
            var wholeValue = binaryReader.ReadInt16();
            return wholeValue + decimalValue;
        }

        public static void WriteFixedPoint(this BinaryWriter binaryWriter, decimal value)
        {
            var wholePart = Math.Floor(value);
            var decimalPart = value < 0 ? (value - wholePart) : (value - Math.Truncate(value));
            binaryWriter.Write((ushort)(decimalPart * 65536));
            binaryWriter.Write((short)wholePart);
        }

        public static byte[] SerializeToBytes(Action<BinaryWriter> serialization)
        {
            using (var buffer = new MemoryStream())
            using (var writer = new BinaryWriter(buffer))
            {
                serialization.Invoke(writer);
                return buffer.ToArray();
            }
        }
    }
}
