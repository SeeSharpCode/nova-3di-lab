using System;
using System.Text;

namespace Nova3diLab.Utility
{
    public static class StringExtensions
    {
        public static byte[] ToBytes(this string value, int length = 0) => Encoding.ASCII.GetBytes(value.PadRight(length, '\0'));
    }
}
