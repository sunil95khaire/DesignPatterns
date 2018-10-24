using System;

namespace Bridge
{
    public class WebServiceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Web Servic\n{0}\n{1}\n", subject, body);
        }
    }
}
