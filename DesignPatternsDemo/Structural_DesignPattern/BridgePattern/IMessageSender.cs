using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.Structural_DesignPattern.BridgePattern
{
    /// <summary>
    /// The 'Bridge/Implementor' interface
    /// </summary>
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}
