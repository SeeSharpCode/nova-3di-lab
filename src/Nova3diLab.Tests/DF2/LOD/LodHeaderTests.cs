using System.IO;
using System.Linq;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.Model.Lod.Tests
{
    public class LodHeaderTests
    {
        public static LodHeader LodHeader => new LodHeader
        {
            Length = 1384,
            BoundingSphereRadius = 1.73205080756888,
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

        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/lod-header.3di");
            Assert.True(expected.SequenceEqual(TestUtils.SerializeToBytes(LodHeader)));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}