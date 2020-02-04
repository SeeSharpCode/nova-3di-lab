using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            var actual = collisionPlaneVectors.SelectMany(collisionPlane => collisionPlane.Serialize()).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }
    }
}