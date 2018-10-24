using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageSender email = new EmailSender();
            IMessageSender web = new WebServiceSender();
            IMessageSender msmq = new MSMQSender();

            Message systemMsg = new SystemMessage
            {
                Subject = "Test Message subject",
                Body = "This is test message body"                
            };

            systemMsg.MessageSender = email;
            systemMsg.Send();

            systemMsg.MessageSender = web;
            systemMsg.Send();

            systemMsg.MessageSender = msmq;
            systemMsg.Send();

            Message userMsg = new UserMessage
            {
                Subject = "Test Message subject",
                Body = "This is test message body",
                UserComments = "User comments"
            };

            userMsg.MessageSender = email;
            userMsg.Send();

            Console.ReadKey();
        }
    }
}
