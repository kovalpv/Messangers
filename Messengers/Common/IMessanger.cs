using System;

namespace Messengers.Common {
    public interface IMessenger : IDisposable {
        void Send (ISendParamater parameter);
        string Receive ();
    }
}