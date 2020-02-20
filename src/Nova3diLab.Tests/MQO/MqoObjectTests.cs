using Nova3diLab.MQO;
using Xunit;

namespace Nova3diLab.Tests.MQO
{
    public class MqoObjectTests
    {
        [Fact]
        public void LoadTests()
        {
            var mqo = MqoObject.Load(@"G:\Games\Novalogic\Delta Force 2\Tools\3di\Box\Box CVs.mqo");
        }
    }
}