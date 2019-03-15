using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nova3diLab.Tests.Properties;
using System.Linq;

namespace Nova3diLab.DF2.Tests
{
    [TestClass()]
    public class GeneralHeaderTests
    {
        [TestMethod()]
        public void GetBytesTest()
        {
            GeneralHeader generalHeader = new GeneralHeader
            {
                Name = "box",
                LodCount = 1,
                Sphere = 0x0001BB67,
                Radius = 0x0001BB67,
                TextureCount = 1,
            };
            
            Assert.IsTrue(Resources.general_header.SequenceEqual(generalHeader.Serialize()));
        }
    }
}