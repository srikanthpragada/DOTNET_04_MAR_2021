using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo.oop
{
    class Account
    {
        // Fields
        private int acno;
        private string ahname;
        private double balance;

        // constructor 
        public Account(int acno, string ahname, double balance = 0)
        {
            this.acno = acno;
            this.ahname = ahname;
            this.balance = balance;
        }

        // Methods
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

        // Property - Readonly property 
        public double CurrentBalance
        {
            get
            {
                return this.balance;
            }
        }
    }

    class TestAccount
    {
        static void Main(string[] args)
        {
            Account a; // object reference 

            a = new Account(1, "Stephen"); // Create object 
            a.Deposit(10000);   // Call method
            a.Deposit(20000);
            a.Withdraw(5000);
            Console.WriteLine(a.CurrentBalance);

            Account a2 = new Account(2, "Jason");
            Console.WriteLine(a2.CurrentBalance);

        }
    }
}
