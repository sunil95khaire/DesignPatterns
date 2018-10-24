using System;

namespace Proxy
{
    internal class ProxyClient : IClient
    {
        ActualClient client = new ActualClient();
        public ProxyClient()
        {
            Console.WriteLine("Proxy client initialized");
        }

        public string GetData()
        {
            return client.GetData();
        }
    }
}