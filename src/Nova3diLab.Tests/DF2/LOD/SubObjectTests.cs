using System.IO;
using System.Linq;
using Xunit;

namespace Nova3diLab.Model.Lod.Tests
{
    public class SubObjectTests
    {
        [Fact]
        public void SerializeTest()
        {
            var subObject = new SubObject
            {
                VertexCount = 8,
                FacesCount = 12,
                NormalsCount = 12,
                CollisionVolumesCount = 1,
                XMaximum = 1,
                YMaximum = 1,
                ZMaximum = 1,
                XMedian = .5m,
                YMedian = .5m,
                ZMedian = .5m,
                SphereRadius = 1.73205080756888m,
                CircleRadius = 1.73205080756888m
            };

            var expected = File.ReadAllBytes("Resources/sub-object.3di");
            Assert.True(expected.SequenceEqual(subObject.Serialize()));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}