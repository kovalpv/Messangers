namespace Messengers.Vendors.Skype {
    public sealed class Skype {

        ExceptionGenerator exceptionGenerator = new ExceptionGenerator ();
        public void Send (string username, string password, string to, string message) {
            exceptionGenerator.ThrowIfConnectCountDivByWithoutExceptionIsEqualZero ();
            System.Console.WriteLine ($"skype send '{message}' from '{username}' to '{to}'");
        }

        public string GetMessage (string username, string password) {
            exceptionGenerator.ThrowIfConnectCountDivByWithoutExceptionIsEqualZero ();
            return $"skype get message for '{username}'";
        }
    }
}