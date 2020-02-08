using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.Model.Lod.Tests
{
    public class CollisionPlaneVectorTests
    {
        [Fact]
        public void SerializeTest()
        {
            var collisionPlaneVectors = new List<CollisionPlaneVector>
            {
                new CollisionPlaneVector(16384, 0, 0, -256),
                new CollisionPlaneVector(-16384, 0, 0, 0),
                new CollisionPlaneVector(0, 16384, 0, -256),
                new CollisionPlaneVector(0, -16384, 0, 0),
                new CollisionPlaneVector(0, 0, 16384, -256),
                new CollisionPlaneVector(0, 0, -16384, 0),
            };

            var expected = File.ReadAllBytes("Resources/collision-planes.3di");
            var actual = collisionPlaneVectors.SelectMany(collisionPlane => TestUtils.SerializeToBytes(collisionPlane)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }
    }
}