using System;
using System.IO;
using Xunit;

namespace Nova3diLab.Utility.Tests
{
    public class BinaryExtensionsTests
    {
        [Fact]
        public void ReadFixedPointTestWithNegativeWholeNumber()
        {
            byte[] bytes = { 0, 0, 0xFD, 0xFF };

            using (var memoryStream = new MemoryStream(bytes))
            using (var binaryReader = new BinaryReader(memoryStream))
            {
                Assert.Equal(-3, binaryReader.ReadFixedPoint());
            }
        }

        [Fact]
        public void ReadFixedPointTestWithNegativeDecimal()
        {
            byte[] bytes = { 0xEE, 0x62, 0xED, 0xFF };

            using (var memoryStream = new MemoryStream(bytes))
            using (var binaryReader = new BinaryReader(memoryStream))
            {
                Assert.Equal(-18.614, binaryReader.ReadFixedPoint());
            }
        }

        [Fact]
        public void ReadFixedPointTestWithPositiveWholeNumber()
        {
            byte[] bytes = { 0, 0, 4, 0 };

            using (var memoryStream = new MemoryStream(bytes))
            using (var binaryReader = new BinaryReader(memoryStream))
            {
                Assert.Equal(4, binaryReader.ReadFixedPoint());
            }
        }

        [Fact]
        public void ReadFixedPointTestWithPositiveDecimal()
        {
            byte[] bytes = { 0x44, 0x6D, 0x07, 0 };

            using (var memoryStream = new MemoryStream(bytes))
            using (var binaryReader = new BinaryReader(memoryStream))
            {
                Assert.Equal(7.427, binaryReader.ReadFixedPoint());
            }
        }
    }
}