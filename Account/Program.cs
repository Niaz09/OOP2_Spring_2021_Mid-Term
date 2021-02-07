using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class Account
    {
        private string accName;
        private string acid;
        private int balance;

        public Account()
        {

        }
        public Account(string accName,string acid,int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public string Acid
        {
            get { return acid; }
            set { acid = value; }
        }
        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("You have deposited Taka " + amount);
        }
        public void Withdraw(int amount)
        {
            if (balance >= amount + 1000)
            {
                balance = balance - amount;
                Console.WriteLine("You have withdrawn Taka " + amount);
            }
            else
            {
                Console.WriteLine("Not enough Balance");
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Account Name: " + accName);
            Console.WriteLine("Account ID: " + acid);
            Console.WriteLine("Balance: " + balance);
        }

    }
}
