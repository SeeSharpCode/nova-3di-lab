using System.Linq;
using Xunit;

namespace Nova3diLab.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void ToBytesTest()
        {
            byte[] expected = { 0x62, 0x6F, 0x78, 0, 0, 0, 0, 0 };
            var actual = "box".ToBytes(8);

            Assert.True(expected.SequenceEqual(actual));
        }
    }
}
