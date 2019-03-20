using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nova3diLab.Tests.Properties;
using System;

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
                SphereRadius = 1.73205080756888m,
                CircleRadius = 1.73205080756888m,
                ZTotal = 1,
                XMin = 0,
                XMax = 1,
                YMin = 0,
                YMax = 1,
                ZMin = 0,
                ZMax = 1,
                VertexCount = 8,
                NormalCount = 12,
                FaceCount = 12,
                SubObjectCount = 1,
                PartAnimCount = 0,
                MaterialCount = 1,
                CollisionPlaneCount = 6,
                CollisionVolumeCount = 1
            };

            Assert.AreEqual(BitConverter.ToString(Resources.lod_header).Replace("-", " "), BitConverter.ToString(lodHeader.Serialize()).Replace("-", " "));
            // Assert.IsTrue(Resources.lod_header.SequenceEqual(lodHeader.Serialize()));
        }

        [TestMethod()]
        public void DeserializeTest()
        {
        }
    }
}