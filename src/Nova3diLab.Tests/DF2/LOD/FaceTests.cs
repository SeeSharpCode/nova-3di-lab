using System.Collections.Generic;
using System.IO;
using System.Linq;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.Model.Lod.Tests
{
    public class FaceTests
    {
        public static List<Face> Faces => new List<Face>
        {
            new Face
            {
                Index = 0,
                U1 = 1,
                U2 = 1,
                U3 = 0,
                V1 = 1,
                V2 = 0,
                V3 = 1,
                Vertex1Index = 5,
                Vertex2Index = 6,
                Vertex3Index = 4,
                Normal1Index = 0,
                Normal2Index = 0,
                Normal3Index = 0,
                Distance = 0,
                XMin = 0,
                XMax = 1,
                YMin = 0,
                YMax = 1,
                ZMin = 0,
                ZMax = 0,
                MaterialIndex = 0
            },
            new Face
            {
                Index = 1,
                U1 = 0,
                U2 = 0,
                U3 = 1,
                V1 = 0,
                V2 = 1,
                V3 = 0,
                Vertex1Index = 7,
                Vertex2Index = 4,
                Vertex3Index = 6,
                Normal1Index = 1,
                Normal2Index = 1,
                Normal3Index = 1,
                Distance = 0,
                XMin = 0,
                XMax = 1,
                YMin = 0,
                YMax = 1,
                ZMin = 0,
                ZMax = 0,
                MaterialIndex = 0
            },
            new Face
            {
                Index = 2,
                U1 = 0,
                U2 = 1,
                U3 = 0,
                V1 = 1,
                V2 = 1,
                V3 = 0,
                Vertex1Index = 0,
                Vertex2Index = 1,
                Vertex3Index = 3,
                Normal1Index = 2,
                Normal2Index = 2,
                Normal3Index = 2,
                Distance = -1,
                XMin = 0,
                XMax = 1,
                YMin = 0,
                YMax = 1,
                ZMin = 1,
                ZMax = 1,
                MaterialIndex = 0
            },
            new Face
            {
                Index = 3,
                U1 = 1,
                U2 = 0,
                U3 = 1,
                V1 = 0,
                V2 = 0,
                V3 = 1,
                Vertex1Index = 2,
                Vertex2Index = 3,
                Vertex3Index = 1,
                Normal1Index = 3,
                Normal2Index = 3,
                Normal3Index = 3,
                Distance = -1,
                XMin = 0,
                XMax = 1,
                YMin = 0,
                YMax = 1,
                ZMin = 1,
                ZMax = 1,
                MaterialIndex = 0
            },
            new Face
            {
                Index = 4,
                U1 = 1,
                U2 = 1,
                U3 = 0,
                V1 = 1,
                V2 = 0,
                V3 = 1,
                Vertex1Index = 7,
                Vertex2Index = 6,
                Vertex3Index = 1,
                Normal1Index = 4,
                Normal2Index = 4,
                Normal3Index = 4,
                Distance = 0,
                XMin = 0,
                XMax = 1,
                YMin = 0,
                YMax = 0,
                ZMin = 0,
                ZMax = 1,
                MaterialIndex = 0
            },
            new Face
            {
                Index = 5,
                U1 = 0,
                U2 = 0,
                U3 = 1,
                V1 = 0,
                V2 = 1,
                V3 = 0,
                Vertex1Index = 2,
                Vertex2Index = 1,
                Vertex3Index = 6,
                Normal1Index = 5,
                Normal2Index = 5,
                Normal3Index = 5,
                Distance = 0,
                XMin = 0,
                XMax = 1,
                YMin = 0,
                YMax = 0,
                ZMin = 0,
                ZMax = 1,
                MaterialIndex = 0
            },
            new Face
            {
                Index = 6,
                U1 = 0,
                U2 = 0,
                U3 = 1,
                V1 = 0,
                V2 = 1,
                V3 = 0,
                Vertex1Index = 0,
                Vertex2Index = 3,
                Vertex3Index = 4,
                Normal1Index = 6,
                Normal2Index = 6,
                Normal3Index = 6,
                Distance = -1,
                XMin = 0,
                XMax = 1,
                YMin = 1,
                YMax = 1,
                ZMin = 0,
                ZMax = 1,
                MaterialIndex = 0
            },
            new Face
            {
                Index = 7,
                U1 = 1,
                U2 = 1,
                U3 = 0,
                V1 = 1,
                V2 = 0,
                V3 = 1,
                Vertex1Index = 5,
                Vertex2Index = 4,
                Vertex3Index = 3,
                Normal1Index = 7,
                Normal2Index = 7,
                Normal3Index = 7,
                Distance = -1,
                XMin = 0,
                XMax = 1,
                YMin = 1,
                YMax = 1,
                ZMin = 0,
                ZMax = 1,
                MaterialIndex = 0
            },
            new Face
            {
                Index = 8,
                U1 = 1,
                U2 = 0,
                U3 = 1,
                V1 = 0,
                V2 = 0,
                V3 = 1,
                Vertex1Index = 7,
                Vertex2Index = 1,
                Vertex3Index = 4,
                Normal1Index = 8,
                Normal2Index = 8,
                Normal3Index = 8,
                Distance = 0,
                XMin = 0,
                XMax = 0,
                YMin = 0,
                YMax = 1,
                ZMin = 0,
                ZMax = 1,
                MaterialIndex = 0
            },
            new Face
            {
                Index = 9,
                U1 = 0,
                U2 = 1,
                U3 = 0,
                V1 = 1,
                V2 = 1,
                V3 = 0,
                Vertex1Index = 0,
                Vertex2Index = 4,
                Vertex3Index = 1,
                Normal1Index = 9,
                Normal2Index = 9,
                Normal3Index = 9,
                Distance = 0,
                XMin = 0,
                XMax = 0,
                YMin = 0,
                YMax = 1,
                ZMin = 0,
                ZMax = 1,
                MaterialIndex = 0
            },
            new Face
            {
                Index = 10,
                U1 = 1,
                U2 = 0,
                U3 = 1,
                V1 = 0,
                V2 = 0,
                V3 = 1,
                Vertex1Index = 5,
                Vertex2Index = 3,
                Vertex3Index = 6,
                Normal1Index = 10,
                Normal2Index = 10,
                Normal3Index = 10,
                Distance = -1,
                XMin = 1,
                XMax = 1,
                YMin = 0,
                YMax = 1,
                ZMin = 0,
                ZMax = 1,
                MaterialIndex = 0
            },
            new Face
            {
                Index = 11,
                U1 = 0,
                U2 = 1,
                U3 = 0,
                V1 = 1,
                V2 = 1,
                V3 = 0,
                Vertex1Index = 2,
                Vertex2Index = 6,
                Vertex3Index = 3,
                Normal1Index = 11,
                Normal2Index = 11,
                Normal3Index = 11,
                Distance = -1,
                XMin = 1,
                XMax = 1,
                YMin = 0,
                YMax = 1,
                ZMin = 0,
                ZMax = 1,
                MaterialIndex = 0
            }
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