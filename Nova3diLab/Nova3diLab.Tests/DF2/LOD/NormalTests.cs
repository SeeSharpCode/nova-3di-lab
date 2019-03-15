using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nova3diLab.Model.Lod;
using Nova3diLab.Tests.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova3diLab.Model.Lod.Tests
{
    [TestClass()]
    public class NormalTests
    {

        [TestMethod()]
        public void SerializeTest()
        {
            List<Normal> normals = new List<Normal>
            {
                new Normal(0, 0, -16384, 1),
                new Normal(0, 0, -16384, 1),
                new Normal(0, 0, 16384, 1),
                new Normal(0, 0, 16384, 1),
                new Normal(0, -16384, 0, 2),
                new Normal(0, -16384, 0, 2),
                new Normal(0, 16384, 0, 2),
                new Normal(0, 16384, 0, 2),
                new Normal(-16384, 0, 0, 4),
                new Normal(-16384, 0, 0, 4),
                new Normal(16384, 0, 0, 4),
                new Normal(16384, 0, 0, 4),
            };

            byte[] normalData = normals.SelectMany(normal => normal.Serialize()).ToArray();
            Assert.IsTrue(Resources.normals.SequenceEqual(normalData));
        }

        [TestMethod()]
        public void DeserializeTest()
        {
        }
    }
}