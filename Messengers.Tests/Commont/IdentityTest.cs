using Messengers.Common;
using NUnit.Framework;

namespace Messengers.Tests.Commont
{
    public class IdentityTest
    {
        
        [Test]
        public void ShouldReturnNewIdentity() {
            var identity = new Identity(username: "testIdentity", password: "testPassword");
            Assert.AreEqual("testIdentity", identity.Username);
            Assert.AreEqual("testPassword", identity.Password);
        }
    }
}