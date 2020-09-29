using Messengers.Common;
using Messengers.Exceptions;
using NUnit.Framework;

namespace Messengers.Tests {
    public class MessengerFactoryTests {
        private MessengerFactory factory;

        [SetUp]
        public void Setup () {
            this.factory = new MessengerFactory ();
        }

        [Test]
        public void ShouldThrowExceptionWhenTypeIsUnregistred () {
            Identity identity = createIdentity ();
            var ex = Assert.Throws<UnregistredMessengerException> (() => factory.GetMessenger (TestMessenger, identity));
            Assert.AreEqual (ex.Message, "Messenger with type [TestMessenger] is not registred");
        }

        private Identity createIdentity () {
            return new Identity (username: "testUser", password: "tooLongPassword");
        }
        const string TestMessenger = "TestMessenger";

        [Test]
        public void ShouldReturnNewInstanceWhenTypeIsRegistred () {
            factory.Registry (TestMessenger, identity => new TestMessenger ());
            var identity = this.createIdentity ();
            var messenger = factory.GetMessenger (TestMessenger, identity);
            Assert.AreEqual (typeof (TestMessenger), messenger.GetType ());
        }

    }
}