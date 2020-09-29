using System;

namespace Messengers.Vendors.Viber
{
    public class ConnectionException : Exception
    {
        public ConnectionException() : base("viber connection error")
        {
        }
    }
}