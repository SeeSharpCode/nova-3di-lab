using System.IO;
using System.Linq;
using Nova3diLab.Tests;
using Xunit;

namespace Nova3diLab.DF2.Tests
{
    public class TextureTests
    {
        public static Texture Texture => new Texture
        {
            Name = "box",
            Index = 0,
            IsLightOn = false,
            Width = 512,
            Height = 512,
        };
        
        [Fact]
        public void GetBytesTest()
        {
            var expected = File.ReadAllBytes("Resources/texture.3di");
            Assert.True(expected.SequenceEqual(TestUtils.SerializeToBytes(Texture)));
        }
    }
}