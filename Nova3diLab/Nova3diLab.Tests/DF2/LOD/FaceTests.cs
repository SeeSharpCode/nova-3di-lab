using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nova3diLab.Tests.Properties;
using System.IO;
using System.Linq;

namespace Nova3diLab.Model.Lod.Tests
{
    [TestClass()]
    public class FaceTests
    {
        [TestMethod()]
        public void SerializeTest()
        {
            Face face = new Face
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
            
            Assert.IsTrue(Resources.face1.SequenceEqual(face.Serialize()));
        }

        [TestMethod()]
        public void DeserializeTest()
        {
        }
    }
}