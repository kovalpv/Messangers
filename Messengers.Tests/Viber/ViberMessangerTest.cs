using Messengers.Common;
using Messengers.Viber;
using Moq;
using NUnit.Framework;

namespace Messengers.Tests {
    public class ViberMessengerTest {
        [Test]
        public void ShouldThrowConnectionErrorWhenCannotConnect () {
            var mockViber = new Mock<IViberClient> ();
            mockViber
                .Setup (viber => viber.Enter (It.IsAny<string> (), It.IsAny<string> ()))
                .Throws (new Vendors.Viber.ConnectionException ());

            var identity = new Identity (username: "viber@user", password: "viberComplicatedPassord*");

            var exception = Assert.Throws<Exceptions.ConnectionException> (() => new ViberMessenger (identity, mockViber.Object));
            Assert.AreEqual("Viber connection error", exception.Message);
        }
    }
}