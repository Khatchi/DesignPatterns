using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciple.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            //Abstract all other functionality away from  
            //the user using the emailService class
            Connect();
            Authenticate();
            Console.WriteLine("Sending email...");
            Disconnect();
        }

        private void Connect()
        {
            Console.WriteLine("Connecting to email server...");
        }

        private void Authenticate()
        {
            Console.WriteLine("Authenticating...");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting from email server...");
        }
    }
}