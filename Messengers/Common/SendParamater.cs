namespace Messengers.Common {
    public class SendParamater : ISendParamater {
        public SendParamater (string to, string message) {
            To = to;
            Message = message;
        }

        public string To { get; }
        public string Message { get; }
    }
}