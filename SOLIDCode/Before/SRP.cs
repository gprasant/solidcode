using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDCode.Before
{
    abstract class BankAccount
    {
        public abstract double Balance { get;}
        public abstract void AddInterest();
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void Transfer(double amount, BankAccount toAccount);
    }
}
