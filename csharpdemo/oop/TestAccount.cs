using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.oop
{
    class Account
    {
        private int acno;
        private String ahname;
        private double balance;

        public Account(int acno, String ahname, double balance = 0)
        {
            this.acno = acno;
            this.ahname = ahname;
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }

        public double GetBalance()
        {
            return this.balance;
        }
    }
    class TestAccount
    {
        static void Main(string[] args)
        {
            Account a = new Account(1, "Mike",20000);
            a.Deposit(10000);
            Console.WriteLine(a.GetBalance());
        }
    }
}
