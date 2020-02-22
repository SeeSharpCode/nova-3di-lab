using Nova3diLab.Mqo;
using Xunit;

namespace Nova3diLab.Tests.Mqo
{
    public class MqoObjectTests
    {
        [Fact]
        public void LoadTests()
        {
            var mqo = MqoModel.Load(@"Resources\Box Object.mqo");
        }
    }
}