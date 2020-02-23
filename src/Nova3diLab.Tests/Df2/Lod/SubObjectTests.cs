using System.IO;
using System.Linq;
using Nova3diLab.Df2.Lod;
using Xunit;

namespace Nova3diLab.Tests.Df2.Lod
{
    public class SubObjectTests
    {
        public static SubObject SubObject => new SubObject(VertexTests.Vertices, FaceTests.Faces.Count, 1);

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