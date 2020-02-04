using System.IO;
using System.Linq;
using Xunit;

namespace Nova3diLab.Model.Lod.Tests
{
    public class FaceTests
    {
        [Fact]
        public void SerializeTest()
        {
            var face = new Face
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
            };
            
            var expected = File.ReadAllBytes("Resources/face1.3di");
            Assert.True(expected.SequenceEqual(face.Serialize()));
        }

        [Fact]
        public void DeserializeTest()
        {
        }
    }
}