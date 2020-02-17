using System.IO;
using System.Linq;
using Nova3diLab.DF2.LOD;
using Xunit;

namespace Nova3diLab.Tests.DF2.LOD
{
    public class LodHeaderTests
    {
        public static LodHeader LodHeader => new LodHeader(
            1384,
            VertexTests.Vertices,
            FaceTests.Faces.Count,
            1,
            CollisionPlaneVectorTests.CollisionPlanes.Count,
            1
        );

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