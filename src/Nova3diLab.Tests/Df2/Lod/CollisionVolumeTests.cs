using System.Collections.Generic;
using System.IO;
using Nova3diLab.Df2.Lod;
using Xunit;

namespace Nova3diLab.Tests.Df2.Lod
{
    public class CollisionVolumeTests
    {
        public static List<Vertex> Vertices => new List<Vertex>
        {
            new Vertex(0, 256, 0),
            new Vertex(0, 0, 256),
            new Vertex(0, 256, 256),
            new Vertex(256, 256, 256),
            new Vertex(256, 256, 0),
            new Vertex(256, 0, 0),
            new Vertex(0, 0, 0),
            new Vertex(256, 0, 256)
        };

        public static CollisionVolume CollisionVolume =>
            new CollisionVolume(CollisionVolumeType.Normal, Vertices, 6);

        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/collision-volume.3di");
            Assert.Equal(expected, TestUtils.SerializeToBytes(CollisionVolume));
        }
    }
}