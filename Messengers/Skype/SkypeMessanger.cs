using Messengers.Common;

namespace Messengers.Skype {
    public class SkypeMessenger : Messenger {
        private readonly ISkypeClient skypeClient;
        private readonly Identity identity;

        public SkypeMessenger (Identity identity, ISkypeClient skypeClient) : base (identity) {
            this.skypeClient = skypeClient;
            this.identity = identity;
        }

        public override string Receive () {
            try {
                return skypeClient.GetMessage (username: this.identity.Username, password: this.identity.Password);
            } catch (Messengers.Vendors.Skype.ConnectionException exception) {
                throw new Exceptions.ConnectionException ("Skype connection error", exception);
            }
        }

        public override void Send (ISendParamater parameter) {
            try {
                skypeClient.Send (username: this.identity.Username, password: this.identity.Password, to: parameter.To, message: parameter.Message);
            } catch (Messengers.Vendors.Skype.ConnectionException exception) {
                throw new Exceptions.ConnectionException ("Skype connection error", exception);
            }
        }
    }
}