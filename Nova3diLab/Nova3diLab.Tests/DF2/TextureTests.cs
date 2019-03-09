using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Nova3diLab.DF2.Tests
{
    [TestClass()]
    public class TextureTests
    {
        [TestMethod()]
        public void GetBytesTest()
        {
            Texture texture = new Texture
            {
                Name = "box",
                Index = 0,
                IsLightOn = false,
                Width = 512,
                Height = 512,
            };

            byte[] expected = Nova3diLab.Tests.Properties.Resources.texture_header;
            Assert.IsTrue(expected.SequenceEqual(texture.GetBytes()));
        }
    }
}