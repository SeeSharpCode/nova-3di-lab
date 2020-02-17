using System.IO;
using System.Linq;
using Nova3diLab.DF2.Tests;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.DF2.LOD.Tests
{
    public class MaterialTests
    {
        public static Material Material => new Material(TextureTests.Texture);

        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/material.3di");
            Assert.True(expected.SequenceEqual(TestUtils.SerializeToBytes(Material)));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}