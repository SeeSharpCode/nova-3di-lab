using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.DF2.LOD.Tests
{
    public class CollisionPlaneVectorTests
    {
        public static List<CollisionPlaneVector> CollisionPlanes => new List<CollisionPlaneVector>
        {
            new CollisionPlaneVector(16384, 0, 0, -256),
            new CollisionPlaneVector(-16384, 0, 0, 0),
            new CollisionPlaneVector(0, 16384, 0, -256),
            new CollisionPlaneVector(0, -16384, 0, 0),
            new CollisionPlaneVector(0, 0, 16384, -256),
            new CollisionPlaneVector(0, 0, -16384, 0),
        };

        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/collision-planes.3di");
            var actual = CollisionPlanes.SelectMany(collisionPlane => TestUtils.SerializeToBytes(collisionPlane)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }
    }
}