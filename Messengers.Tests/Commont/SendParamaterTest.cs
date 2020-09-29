using Messengers.Common;
using NUnit.Framework;

namespace Messengers.Tests.Commont
{
    public class SendParamaterTest
    {
        
        [Test]
        public void ShouldReturnNewSendParamater() {
            var sendParamater = new SendParamater(to: "Helen", message: "Helen, will you go to school?");
            Assert.AreEqual("Helen", sendParamater.To);
            Assert.AreEqual("Helen, will you go to school?", sendParamater.Message);
        }
    }
}