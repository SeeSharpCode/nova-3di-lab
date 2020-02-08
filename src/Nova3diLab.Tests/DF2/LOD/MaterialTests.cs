using System.IO;
using System.Linq;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.Model.Lod.Tests
{
    public class MaterialTests
    {
        [Fact]
        public void SerializeTest()
        {
            var material = new Material
            {
                Name = "box",
            };

            var expected = File.ReadAllBytes("Resources/material.3di");
            Assert.True(expected.SequenceEqual(TestUtils.SerializeToBytes(material)));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}