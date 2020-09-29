using Messengers.Common;
using Messengers.Skype;
using Moq;
using NUnit.Framework;

namespace Messengers.Tests {
    public class SkypeTests {
        private Mock<ISkypeClient> mockSkypeClient;
        private SkypeMessenger skype;

        [SetUp]
        public void Setup () {
            mockSkypeClient = new Mock<ISkypeClient> ();
            var identity = new Identity (username: "skype@user", password: "tooLongTestPassword");
            skype = new SkypeMessenger (identity, mockSkypeClient.Object);
        }

        [Test]
        public void ShouldGetMessageWhenGetSkypeMessenger () {
            mockSkypeClient
                .Setup (s => s.GetMessage (It.IsAny<string> (), It.IsAny<string> ()))
                .Returns ("skype test message");

            var message = skype.Receive ();

            Assert.AreEqual ("skype test message", message);
        }

        [Test]
        public void ShouldThrowConnectionExceptionWhenCannotConnectionToSend () {

            mockSkypeClient
                .Setup (skype => skype.Send (
                    It.IsAny<string> (),
                    It.IsAny<string> (),
                    It.IsAny<string> (),
                    It.IsAny<string> ()))
                .Throws (new Vendors.Skype.ConnectionException ());

            var ex = Assert.Throws<Exceptions.ConnectionException> (() => skype.Send (new SendParamater (to: "Nina", message: "Hi, Nina!")));

            Assert.AreEqual("Skype connection error", ex.Message);
        }

        [Test]
        public void ShouldThrowConnectionExceptionWhenCannotConnectionToRecive () {

            mockSkypeClient
                .Setup (skype => skype.GetMessage (
                    It.IsAny<string> (),
                    It.IsAny<string> ()))
                .Throws (new Vendors.Skype.ConnectionException ());

            var ex = Assert.Throws<Exceptions.ConnectionException> (() => skype.Receive ());

            Assert.AreEqual("Skype connection error", ex.Message);
        }
    }

}