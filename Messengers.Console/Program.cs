using Messengers.Common;
using Messengers.Skype;
using Messengers.Viber;

namespace Messengers.Console {
    class Program {
        static void Main (string[] args) {
            MessengerFactory factory = InitFactory ();

            var messages = new string[3] { "hello my dier friend!", "how are you doing", "bye!" };

            var skypeIdentity = new Identity (username: "skype@user", password: "password");
            var viberIdentity = new Identity (username: "viber@user", password: "password");

            SendMessages (
                factory: factory,
                messages: new [] { "hello my dier friend!", "how are you doing", "bye!" },
                identity : skypeIdentity,
                to: "Andrew",
                messengerType : Constants.Skype);

            SendMessages (
                factory: factory,
                messages: new [] { "hi Nina! Will you go to the party on friday?" },
                identity : skypeIdentity,
                to: "Nina",
                messengerType : Constants.Viber);

            SendMessages (
                factory : factory,
                messages : new [] { "hi Nina! Will you go to the party on friday?" },
                identity : skypeIdentity,
                to: "Nina",
                messengerType : Constants.Viber);
            SendMessages (
                factory : factory,
                messages : new [] { "hi Nina! Will you go to the party on friday?" },
                identity : skypeIdentity,
                to: "Nina",
                messengerType : Constants.Viber);
        }

        private static void SendMessages (MessengerFactory factory,
            string[] messages,
            Identity identity,
            string to,
            string messengerType) {

            IMessenger messenger = null;
            try {
                messenger = factory.GetMessenger (messengerType, identity);
                foreach (var message in messages) {
                    try {
                        messenger.Send (new SendParamater (to: to, message: message));
                    } catch (Exceptions.ConnectionException exception) {
                        Logger.Error(exception: exception);
                    }

                }
            } catch (Exceptions.ConnectionException exception) {
                Logger.Error(exception: exception);
            } finally {
                if(messenger != null){
                    messenger.Dispose ();
                }
            }
        }

        private static MessengerFactory InitFactory () {
            var factory = new MessengerFactory ();
            factory.Registry (Constants.Skype, identity => new SkypeMessenger (identity, new SkypeClient()));
            factory.Registry (Constants.Viber, identity => new ViberMessenger (identity, new ViberClient ()));
            return factory;
        }
    }
}