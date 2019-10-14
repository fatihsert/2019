using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Inheritance
{
    public abstract class Account
    {
        protected decimal balance;
        public decimal GetBalance()
        {
            return balance;
        }
    }

    public class DepositAccount : Account
    {
        public DepositAccount()
        {
            this.balance = 100;
        }

    }
}
