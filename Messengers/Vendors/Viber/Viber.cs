namespace Messengers.Vendors.Viber {
    public sealed class Viber {
        private string phone;
        private string password;
        
        static ExceptionGenerator exceptionGenerator = new ExceptionGenerator ();

        public void Enter (string phone, string password) {
            this.phone = phone;
            this.password = password;
            exceptionGenerator.ThrowIfConnectCountDivByWithoutExceptionIsEqualZero();
        }
        public void Leave () { }
        public void Send (string to, string message) {
            System.Console.WriteLine ($"viber send '{message}' from '{this.phone}' to '{to}'");
        }

        public string Receive () {
            return $"viber get message for '{this.phone}'";
        }
    }
}