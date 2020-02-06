using System.IO;
using System.Linq;
using Xunit;

namespace Nova3diLab.DF2.Tests
{
    public class ModelHeaderTests
    {
        [Fact]
        public void GetBytesTest()
        {
            var generalHeader = new ModelHeader
            {
                Name = "box",
                LodCount = 1,
                BoundingSphereRadius = 1.73205080756888,
                TextureCount = 1,
            };

            var expected = File.ReadAllBytes("Resources/general-header.3di");
            Assert.True(expected.SequenceEqual(generalHeader.Serialize()));
        }
    }
}