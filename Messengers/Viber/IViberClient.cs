namespace Messengers.Viber
{
    public interface IViberClient
    {
        void Enter(string phone, string password);
        void Leave();
        string Receive();
        void Send(string to, string message);
    }
}