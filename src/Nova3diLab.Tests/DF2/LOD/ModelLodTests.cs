using System.Collections.Generic;
using System.IO;
using Nova3diLab.Model.Lod;
using Nova3diLab.Model.Lod.Tests;
using Xunit;

namespace Nova3diLab.Tests.DF2.LOD
{
    public class ModelLodTests
    {
        public static ModelLod ModelLod => new ModelLod
        {
            Header = LodHeaderTests.LodHeader,
            Vertices = VertexTests.Vertices,
            Normals = NormalTests.Normals,
            Faces = FaceTests.Faces,
            SubObjects = new List<SubObject> { SubObjectTests.SubObject },
            CollisionPlaneVectors = CollisionPlaneVectorTests.CollisionPlanes,
            CollisionVolumes = new List<CollisionVolume> { CollisionVolumeTests.CollisionVolume },
            Materials = new List<Material> { MaterialTests.Material }
        };
        
        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/lod.3di");
            Assert.Equal(expected, TestUtils.SerializeToBytes(ModelLod));
        }
    }
}