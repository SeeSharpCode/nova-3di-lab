using System.IO;
using System.Linq;
using Nova3diLab.Utility;
using Nova3diLab.Tests.Df2.Lod;
using Xunit;
using Nova3diLab.Df2;

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