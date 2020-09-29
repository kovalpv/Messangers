namespace Messengers.Skype {
    public class SkypeClient : ISkypeClient {
        private Vendors.Skype.Skype skype = new Vendors.Skype.Skype ();
        public void Send (string username, string password, string to, string message) {
            skype.Send (
                username: username,
                password: password,
                to: to,
                message: message);
        }

        public string GetMessage (string username, string password) {
            return skype.GetMessage (username: username, password: password);
        }
    }
}