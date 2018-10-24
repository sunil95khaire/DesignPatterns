using System;

namespace Proxy
{
    internal class ActualClient : IClient
    {
        string data;
        public ActualClient()
        {
            Console.WriteLine("Actual client initialized");
            data = "Sunil Khaire";
        }
        public string GetData()
        {
            return data;
        }
    }
}