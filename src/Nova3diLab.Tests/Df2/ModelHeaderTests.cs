using Nova3diLab.Df2;
using Nova3diLab.Df2.Lod;
using Nova3diLab.Tests.Df2.Lod;
using System.IO;
using System.Linq;
using Xunit;

namespace Nova3diLab.Tests.Df2
{
    public class ModelHeaderTests
    {
        public static ModelHeader ModelHeader => new ModelHeader("box", VertexTests.Vertices.CalculateBoundingSphereRadius(), 1);

        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/general-header.3di");
            Assert.True(expected.SequenceEqual(TestUtils.SerializeToBytes(ModelHeader)));
        }
    }
}