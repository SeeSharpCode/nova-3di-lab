using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Nova3diLab.Utility.Tests
{
    [TestClass()]
    public class NumberExtensionsTests
    {
        [TestMethod()]
        public void ToDF2BytesTestWithPositiveNumber()
        {
            byte[] number = 7.4287036842059.ToDF2Bytes();
            string hex = BitConverter.ToString(number).Replace("-", "");
            Assert.AreEqual("BF6D0700", hex);
        }

        [TestMethod()]
        public void ToDF2BytesTestWithPositiveWholeNumber()
        {
            byte[] number = ((double)8).ToDF2Bytes();
            string hex = BitConverter.ToString(number).Replace("-", "");
            Assert.AreEqual("00000800", hex);
        }

        [TestMethod()]
        public void ToDF2BytesTestWithNegativeNumber()
        {
            byte[] number = (-3.5703125).ToDF2Bytes();
            string hex = BitConverter.ToString(number).Replace("-", "");
            Assert.AreEqual("006EFCFF", hex);
        }

        [TestMethod()]
        public void ToDF2BytesTestWithNegativeWholeNumber()
        {
            byte[] number = ((double)-3).ToDF2Bytes();
            string hex = BitConverter.ToString(number).Replace("-", "");
            Assert.AreEqual("0000FDFF", hex);
        }
    }
}