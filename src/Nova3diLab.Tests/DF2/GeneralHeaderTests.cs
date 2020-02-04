using System.IO;
using System.Linq;
using Xunit;

namespace Nova3diLab.DF2.Tests
{
    public class GeneralHeaderTests
    {
        [Fact]
        public void GetBytesTest()
        {
            var generalHeader = new GeneralHeader
            {
                Name = "box",
                LodCount = 1,
                SphereRadius = 1.73205080756888m,
                CircleRadius = 1.73205080756888m,
                TextureCount = 1,
            };

            var expected = File.ReadAllBytes("Resources/general-header.3di");
            Assert.True(expected.SequenceEqual(generalHeader.Serialize()));
        }
    }
}