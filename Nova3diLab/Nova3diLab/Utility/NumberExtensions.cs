using System;
using System.Collections.Generic;

namespace Nova3diLab.Utility
{
    public static class NumberExtensions
    {
        private static bool IsWholeNegativeNumber(double number) => number < 0 && (number % 1 == 0);
        private static double GetNegativeDecimal(double number) => 1 - ((short)number - number);

        /// <summary>
        /// Converts a double to DF2's 4-byte float format.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static byte[] ToDF2Bytes(this double number)
        {
            short wholeNumber = (short)number;
            double decimalPart = IsWholeNegativeNumber(number) ? GetNegativeDecimal(number) : number - wholeNumber;
            short wholeNumberRoundedDown = (short)Math.Floor(number);

            List<byte> bytes = new List<byte>();
            // TODO would ushort work here?
            bytes.AddRange(BitConverter.GetBytes((short)(decimalPart*65536)));
            bytes.AddRange(BitConverter.GetBytes(wholeNumberRoundedDown));
            return bytes.ToArray();
        }
    }
}
