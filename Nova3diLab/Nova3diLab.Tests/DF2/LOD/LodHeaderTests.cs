using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Nova3diLab.Model.Lod.Tests
{
    [TestClass()]
    public class LodHeaderTests
    {
        [TestMethod()]
        public void SerializeTest()
        {
            LodHeader lodHeader = new LodHeader
            {
                Length = 1384,
                SphereRadius = 0x0001BB67,
                CircleRadius = 0x0001BB67,
                ZTotal = 1.000f,
                XMin = 0,
                XMax = 1.000f,
                YMin = 0,
                YMax = 1.000f,
                ZMin = 0,
                ZMax = 1.000f,
                VertexCount = 8,
                NormalCount = 12,
                FaceCount = 12,
                SubObjectCount = 1,
                PartAnimCount = 0,
                MaterialCount = 1,
                CollisionPlaneCount = 6,
                CollisionVolumeCount = 1
            };

            byte[] expected = Nova3diLab.Tests.Properties.Resources.lod_header;
            Assert.IsTrue(expected.SequenceEqual(lodHeader.Serialize()));
        }

        [TestMethod()]
        public void DeserializeTest()
        {
        }
    }
}