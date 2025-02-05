using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciple.Encapsulation
{
    public class BankAccount
    {
        
        private decimal balance;

        public BankAccount(decimal balance)
        {
            Deposite(balance);
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposite(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Deposite amount must be positive");
            }

            this.balance += amount;

        }

        public void Withraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("This amount must be positive");
            }

            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            this.balance -= amount;
        }
    }
}