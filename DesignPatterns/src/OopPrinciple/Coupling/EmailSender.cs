using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciple.Coupling
{
    public class EmailSender : INotificationService
    {
       
        public void SendNotification(string message)
        {
            // email logic
            Console.WriteLine("Sending email: " + message);
        }
    }
}