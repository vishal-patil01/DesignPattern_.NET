using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural_DesignPattern.BridgePattern
{
    /// <summary>
    /// The 'ConcreteImplementor' class
    /// </summary>
    public class MSMQSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("MSMQ\n{0}\n{1}\n", subject, body);
        }
    }
}
