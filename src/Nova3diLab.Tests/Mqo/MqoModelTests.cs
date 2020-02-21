using Nova3diLab.Mqo;
using Xunit;

namespace Nova3diLab.Tests.Mqo
{
    public class MqoObjectTests
    {
        [Fact]
        public void LoadTests()
        {
            var mqo = MqoModel.Load(@"G:\Games\Novalogic\Delta Force 2\Tools\3di\Box\Box CVs.mqo");
        }
    }
}