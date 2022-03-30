using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;
        public double Deposit(double balance)
        {
            _balance += balance;
        }

        public double GetBalance()
        {
            return _balance;
        }
        
        public BankAccount()
        {

        }

    }
}
