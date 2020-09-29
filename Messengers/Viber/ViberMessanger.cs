using Messengers.Common;

namespace Messengers.Viber {
    public class ViberMessenger : Messenger {
        private readonly IViberClient viberClient;
        private readonly Identity identity;

        public ViberMessenger (Identity identity, IViberClient viberClient) : base (identity)
        {
            this.viberClient = viberClient;
            this.identity = identity;
            connect();
        }

        private void connect()
        {
            try
            {
                this.viberClient.Enter(phone: identity.Username, password: identity.Password);
            }
            catch (Vendors.Viber.ConnectionException exception)
            {
                throw new Exceptions.ConnectionException("Viber connection error", exception);
            }
        }

        public override void Dispose () {
            this.viberClient.Leave ();
            base.Dispose ();
        }
        public override string Receive () {
            return viberClient.Receive ();
        }

        public override void Send (ISendParamater parameter) {
            viberClient.Send (to: parameter.To, message: parameter.Message);
        }
    }
}