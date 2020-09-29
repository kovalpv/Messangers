namespace Messengers.Viber {
    public class ViberClient : IViberClient {
        private Vendors.Viber.Viber viber = new Vendors.Viber.Viber ();
        public void Enter (string phone, string password) {
            viber.Enter (phone: phone, password: password);
        }
        public void Leave () {
            viber.Leave ();
        }
        public void Send (string to, string message) {
            viber.Send (to: to, message: message);
        }

        public string Receive () {
            return viber.Receive ();
        }
    }
}