namespace Messengers.Common {
    public abstract class Messenger : IMessenger {

        public Messenger (Identity identity) {

        }

        public virtual void Dispose () { }

        public abstract string Receive ();

        public abstract void Send (ISendParamater parameter);
    }
}