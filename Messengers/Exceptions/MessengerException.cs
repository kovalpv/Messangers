using System;

namespace Messengers.Exceptions {
    public class MessengerException : Exception {
        public MessengerException () : base () { }
        public MessengerException (string message) : base (message) { }
        public MessengerException (string message, Exception innerException) : base (message, innerException) { }
    }
}