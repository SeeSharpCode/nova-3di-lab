using System.IO;
using System.Linq;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.Model.Lod.Tests
{
    public class SubObjectTests
    {
        public static SubObject SubObject => new SubObject
        {
            VertexCount = 8,
            FacesCount = 12,
            NormalsCount = 12,
            CollisionVolumesCount = 1,
            XMaximum = 1,
            YMaximum = 1,
            ZMaximum = 1,
            XMedian = .5,
            YMedian = .5,
            ZMedian = .5,
            BoundingSphereRadius = 1.73205080756888
        };

        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/sub-object.3di");
            Assert.True(expected.SequenceEqual(TestUtils.SerializeToBytes(SubObject)));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}