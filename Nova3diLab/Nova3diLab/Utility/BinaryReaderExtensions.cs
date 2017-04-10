using System;
using System.IO;

namespace Nova3diLab.Utility
{
    public static class BinaryReaderExtensions
    {
        public static string ReadCleanedString(this BinaryReader binaryReader)
        {
            return binaryReader.ReadString().Replace("\0", String.Empty);
        }
    }
}
