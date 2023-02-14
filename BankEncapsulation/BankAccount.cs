using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double amount)
        {
            Console.WriteLine($"We are adding {amount, 0:c} to your accaount");
            _balance = amount;
        }

        public double GetBalance()
        {
            return _balance;
        }

        //public void Withdraw(double subtract) 
        //{
        //    Console.WriteLine($"We are subtracting {subtract, 0:c} from your account");
        //}

        
    }
}
