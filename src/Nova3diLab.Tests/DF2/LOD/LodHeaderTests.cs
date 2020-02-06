using System.IO;
using System.Linq;
using Xunit;

namespace Nova3diLab.Model.Lod.Tests
{
    public class LodHeaderTests
    {
        [Fact]
        public void SerializeTest()
        {
            var lodHeader = new LodHeader
            {
                Length = 1384,
                SphereRadius = 1.73205080756888,
                CircleRadius = 1.73205080756888,
                ZTotal = 1,
                XMin = 0,
                XMax = 1,
                YMin = 0,
                YMax = 1,
                ZMin = 0,
                ZMax = 1,
                VertexCount = 8,
                NormalCount = 12,
                FaceCount = 12,
                SubObjectCount = 1,
                PartAnimCount = 0,
                MaterialCount = 1,
                CollisionPlaneCount = 6,
                CollisionVolumeCount = 1
            };

            var expected = File.ReadAllBytes("Resources/lod-header.3di");
            Assert.True(expected.SequenceEqual(lodHeader.Serialize()));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}