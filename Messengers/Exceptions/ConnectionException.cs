using System;

namespace Messengers.Exceptions {
    public class ConnectionException : MessengerException
    {
        public ConnectionException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}