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
                SphereRadius = 1.73205080756888m,
                CircleRadius = 1.73205080756888m,
                TextureCount = 1,
            };
            
            Assert.IsTrue(Resources.general_header.SequenceEqual(generalHeader.Serialize()));
        }
    }
}