using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nova3diLab.DF2.LOD;
using Xunit;

namespace Nova3diLab.Tests.DF2.LOD
{
    public class FaceTests
    {
        public static List<Face> Faces => new List<Face>
        {
            new Face(
                0,
                new List<Tuple<double, double>> { Tuple.Create(1.0, 1.0), Tuple.Create(1.0, 0.0), Tuple.Create(0.0, 1.0) },
                new List<Tuple<int, Vertex>> { Tuple.Create(5, VertexTests.Vertices[5]), Tuple.Create(6, VertexTests.Vertices[6]), Tuple.Create(4, VertexTests.Vertices[4]) },
                0
            ),
            new Face(
                1,
                new List<Tuple<double, double>> { Tuple.Create(0.0, 0.0), Tuple.Create(0.0, 1.0), Tuple.Create(1.0, 0.0) },
                new List<Tuple<int, Vertex>> { Tuple.Create(7, VertexTests.Vertices[7]), Tuple.Create(4, VertexTests.Vertices[4]), Tuple.Create(6, VertexTests.Vertices[6]) },
                0
            ),
            new Face(
                2,
                new List<Tuple<double, double>> { Tuple.Create(0.0, 1.0), Tuple.Create(1.0, 1.0), Tuple.Create(0.0, 0.0) },
                new List<Tuple<int, Vertex>> { Tuple.Create(0, VertexTests.Vertices[0]), Tuple.Create(1, VertexTests.Vertices[1]), Tuple.Create(3, VertexTests.Vertices[3]) },
                0
            ),
            new Face(
                3,
                new List<Tuple<double, double>> { Tuple.Create(1.0, 0.0), Tuple.Create(0.0, 0.0), Tuple.Create(1.0, 1.0) },
                new List<Tuple<int, Vertex>> { Tuple.Create(2, VertexTests.Vertices[2]), Tuple.Create(3, VertexTests.Vertices[3]), Tuple.Create(1, VertexTests.Vertices[1]) },
                0
            ),
            new Face(
                4,
                new List<Tuple<double, double>> { Tuple.Create(1.0, 1.0), Tuple.Create(1.0, 0.0), Tuple.Create(0.0, 1.0) },
                new List<Tuple<int, Vertex>> { Tuple.Create(7, VertexTests.Vertices[7]), Tuple.Create(6, VertexTests.Vertices[6]), Tuple.Create(1, VertexTests.Vertices[1]) },
                0
            ),
            new Face(
                5,
                new List<Tuple<double, double>> { Tuple.Create(0.0, 0.0), Tuple.Create(0.0, 1.0), Tuple.Create(1.0, 0.0) },
                new List<Tuple<int, Vertex>> { Tuple.Create(2, VertexTests.Vertices[2]), Tuple.Create(1, VertexTests.Vertices[1]), Tuple.Create(6, VertexTests.Vertices[6]) },
                0
            ),
            new Face(
                6,
                new List<Tuple<double, double>> { Tuple.Create(0.0, 0.0), Tuple.Create(0.0, 1.0), Tuple.Create(1.0, 0.0) },
                new List<Tuple<int, Vertex>> { Tuple.Create(0, VertexTests.Vertices[0]), Tuple.Create(3, VertexTests.Vertices[3]), Tuple.Create(4, VertexTests.Vertices[4]) },
                0
            ),
            new Face(
                7,
                new List<Tuple<double, double>> { Tuple.Create(1.0, 1.0), Tuple.Create(1.0, 0.0), Tuple.Create(0.0, 1.0) },
                new List<Tuple<int, Vertex>> { Tuple.Create(5, VertexTests.Vertices[5]), Tuple.Create(4, VertexTests.Vertices[4]), Tuple.Create(3, VertexTests.Vertices[3]) },
                0
            ),
            new Face(
                8,
                new List<Tuple<double, double>> { Tuple.Create(1.0, 0.0), Tuple.Create(0.0, 0.0), Tuple.Create(1.0, 1.0) },
                new List<Tuple<int, Vertex>> { Tuple.Create(7, VertexTests.Vertices[7]), Tuple.Create(1, VertexTests.Vertices[1]), Tuple.Create(4, VertexTests.Vertices[4]) },
                0
            ),
            new Face(
                9,
                new List<Tuple<double, double>> { Tuple.Create(0.0, 1.0), Tuple.Create(1.0, 1.0), Tuple.Create(0.0, 0.0) },
                new List<Tuple<int, Vertex>> { Tuple.Create(0, VertexTests.Vertices[0]), Tuple.Create(4, VertexTests.Vertices[4]), Tuple.Create(1, VertexTests.Vertices[1]) },
                0
            ),
            new Face(
                10,
                new List<Tuple<double, double>> { Tuple.Create(1.0, 0.0), Tuple.Create(0.0, 0.0), Tuple.Create(1.0, 1.0) },
                new List<Tuple<int, Vertex>> { Tuple.Create(5, VertexTests.Vertices[5]), Tuple.Create(3, VertexTests.Vertices[3]), Tuple.Create(6, VertexTests.Vertices[6]) },
                0
            ),
            new Face(
                11,
                new List<Tuple<double, double>> { Tuple.Create(0.0, 1.0), Tuple.Create(1.0, 1.0), Tuple.Create(0.0, 0.0) },
                new List<Tuple<int, Vertex>> { Tuple.Create(2, VertexTests.Vertices[2]), Tuple.Create(6, VertexTests.Vertices[6]), Tuple.Create(3, VertexTests.Vertices[3]) },
                0
            )
        };

        [Fact]
        public void SerializeTest()
        {
            var expected = File.ReadAllBytes("Resources/faces.3di");
            var actual = Faces.SelectMany(face => TestUtils.SerializeToBytes(face)).ToArray();
            Assert.True(expected.SequenceEqual(actual));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}