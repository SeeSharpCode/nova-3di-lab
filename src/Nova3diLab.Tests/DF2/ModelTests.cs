using System.Collections.Generic;
using Nova3diLab.DF2;
using Nova3diLab.Tests.DF2.LOD;
using Xunit;
using Nova3diLab.DF2.LOD;
using System.IO;
using System.Linq;

namespace Nova3diLab.Tests.DF2
{
    public class ModelTests
    {
        [Fact]
        public void SerializeTest()
        {
            var model = new Model(
                "box",
                new List<Texture> { TextureTests.Texture },
                VertexTests.Vertices,
                FaceTests.Faces,
                CollisionPlaneVectorTests.CollisionPlanes,
                new List<CollisionVolume> { CollisionVolumeTests.CollisionVolume }
            );

            var expected = File.ReadAllBytes("Resources/box.3di");
            var actual = TestUtils.SerializeToBytes(model);
            Assert.True(expected.SequenceEqual(actual));
        }
    }
}