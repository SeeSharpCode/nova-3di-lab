using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Nova3diLab.Utility.Tests
{
    [TestClass()]
    public class BinaryExtensionsTests
    {
        [TestMethod()]
        public void ReadFixedPointTestWithNegativeWholeNumber()
        {
            byte[] bytes = { 0, 0, 0xFD, 0xFF };

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            using (BinaryReader binaryReader = new BinaryReader(memoryStream))
            {
                Assert.AreEqual(-3, binaryReader.ReadFixedPoint());
            }
        }

        [TestMethod()]
        public void ReadFixedPointTestWithNegativeDecimal()
        {
            byte[] bytes = { 0xEE, 0x62, 0xED, 0xFF };

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            using (BinaryReader binaryReader = new BinaryReader(memoryStream))
            {
                Assert.AreEqual((decimal)-18.614, Math.Round(binaryReader.ReadFixedPoint(), 3));
            }
        }

        [TestMethod()]
        public void ReadFixedPointTestWithPositiveWholeNumber()
        {
            byte[] bytes = { 0, 0, 4, 0 };

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            using (BinaryReader binaryReader = new BinaryReader(memoryStream))
            {
                Assert.AreEqual(4, binaryReader.ReadFixedPoint());
            }
        }

        [TestMethod()]
        public void ReadFixedPointTestWithPositiveDecimal()
        {
            byte[] bytes = { 0x44, 0x6D, 0x07, 0 };

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            using (BinaryReader binaryReader = new BinaryReader(memoryStream))
            {
                Assert.AreEqual((decimal)7.427,Math.Round(binaryReader.ReadFixedPoint(), 3));
            }
        }
    }
}