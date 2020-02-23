using System.IO;
using System.Linq;
using Nova3diLab.Df2.Lod;
using Xunit;

namespace Nova3diLab.Tests.Df2.Lod
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