using System.IO;
using System.Linq;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.DF2.Tests
{
    public class ModelHeaderTests
    {
        public static ModelHeader ModelHeader => new ModelHeader
        {
            Name = "box",
            LodCount = 1,
            BoundingSphereRadius = 1.73205080756888,
            TextureCount = 1,
        };

        [Fact]
        public void GetBytesTest()
        {
            var expected = File.ReadAllBytes("Resources/general-header.3di");
            Assert.True(expected.SequenceEqual(TestUtils.SerializeToBytes(ModelHeader)));
        }
    }
}