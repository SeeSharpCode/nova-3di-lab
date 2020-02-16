using System.Collections.Generic;
using System.IO;
using Nova3diLab.DF2;
using Nova3diLab.DF2.Tests;
using Nova3diLab.Model.Lod;
using Nova3diLab.Model.Lod.Tests;
using Xunit;

namespace Nova3diLab.Tests.DF2.LOD
{
    public class ModelLodTests
    {
        public static ModelLod ModelLod => new ModelLod(
            VertexTests.Vertices,
            FaceTests.Faces,
            new List<Texture> { TextureTests.Texture },
            CollisionPlaneVectorTests.CollisionPlanes,
            new List<CollisionVolume> { CollisionVolumeTests.CollisionVolume }
        );
        
        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/lod.3di");
            Assert.Equal(expected, TestUtils.SerializeToBytes(ModelLod));
        }
    }
}