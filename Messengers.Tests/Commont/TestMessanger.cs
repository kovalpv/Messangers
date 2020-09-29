using Messengers.Common;

namespace Messengers.Tests {
    class TestMessenger : IMessenger {
        public void Dispose () {
            throw new System.NotImplementedException ();
        }

        public string Receive () {
            throw new System.NotImplementedException ();
        }

        public void Send (ISendParamater parameter) {
            throw new System.NotImplementedException ();
        }
    }

}