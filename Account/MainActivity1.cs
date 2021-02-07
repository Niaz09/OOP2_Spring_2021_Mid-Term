using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class MainActivity1
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Niaz", "567", 50000);
            Account a2 = new Account("James", "765", 20000);

            a1.ShowInfo();
            a1.Deposit(3000);
            a1.Withdraw(23000);
            a2.ShowInfo();
            a2.Deposit(5000);
            a2.Withdraw(1000);
        }
    }
}
