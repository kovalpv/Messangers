namespace Messengers.Skype
{
    public interface ISkypeClient
    {
        string GetMessage(string username, string password);
        void Send(string username, string password, string to, string message);
    }
}