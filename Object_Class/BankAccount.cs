using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassObject
{
    internal class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (balance < amount) Console.WriteLine("Insuficient balance");
            else
            balance -= amount;
        }
        public override string ToString()
        {
            return $"Account Id{Id}, balance {Balance}";
        }
    }
}
