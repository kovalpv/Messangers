using System;

namespace Messengers.Vendors.Skype
{
    public class ConnectionException : Exception
    {
        public ConnectionException() : base("skype connection error")
        {
        }
    }
}