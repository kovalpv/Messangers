namespace Messengers.Common {
    public class Identity {
        public Identity (string username, string password) {
            Username = username;
            Password = password;
        }

        public string Username { get; }
        public string Password { get; }
    }
}