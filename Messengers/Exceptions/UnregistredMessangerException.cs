namespace Messengers.Exceptions {
    public class UnregistredMessengerException : MessengerException {
        public UnregistredMessengerException (string messengerType) : base ($"Messenger with type [{messengerType}] is not registred") { }
    }
}