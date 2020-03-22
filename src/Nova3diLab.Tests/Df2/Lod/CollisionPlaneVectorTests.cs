using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nova3diLab.Df2.Lod;
using Xunit;

namespace Nova3diLab.Tests.Df2.Lod
{
    public class CollisionPlaneVectorTests
    {
        private static readonly List<Face> faces = new List<Face>
        {
            new Face(
                0,
                null,
                new List<Tuple<int, Vertex>> { Tuple.Create(3, CollisionVolumeTests.Vertices[3]), Tuple.Create(5, CollisionVolumeTests.Vertices[5]), Tuple.Create(4, CollisionVolumeTests.Vertices[4]) },
                0
            ),
            new Face(
                0,
                null,
                new List<Tuple<int, Vertex>> { Tuple.Create(1, CollisionVolumeTests.Vertices[1]), Tuple.Create(0, CollisionVolumeTests.Vertices[0]), Tuple.Create(6, CollisionVolumeTests.Vertices[6]) },
                0
            ),
            new Face(
                0,
                null,
                new List<Tuple<int, Vertex>> { Tuple.Create(2, CollisionVolumeTests.Vertices[2]), Tuple.Create(4, CollisionVolumeTests.Vertices[4]), Tuple.Create(0, CollisionVolumeTests.Vertices[0]) },
                0
            ),
            new Face(
                0,
                null,
                new List<Tuple<int, Vertex>> { Tuple.Create(7, CollisionVolumeTests.Vertices[7]), Tuple.Create(6, CollisionVolumeTests.Vertices[6]), Tuple.Create(5, CollisionVolumeTests.Vertices[5]) },
                0
            ),
            new Face(
                0,
                null,
                new List<Tuple<int, Vertex>> { Tuple.Create(3, CollisionVolumeTests.Vertices[3]), Tuple.Create(1, CollisionVolumeTests.Vertices[1]), Tuple.Create(7, CollisionVolumeTests.Vertices[7]) },
                0
            ),
            new Face(
                0,
                null,
                new List<Tuple<int, Vertex>> { Tuple.Create(6, CollisionVolumeTests.Vertices[6]), Tuple.Create(4, CollisionVolumeTests.Vertices[4]), Tuple.Create(5, CollisionVolumeTests.Vertices[5]) },
                0
            ),
        };

        public static List<CollisionPlaneVector> CollisionPlanes => faces.Select(face => face.CollisionPlaneVector).ToList();

        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/collision-planes.3di");
            var actual = CollisionPlanes.SelectMany(collisionPlane => TestUtils.SerializeToBytes(collisionPlane)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }
    }
}