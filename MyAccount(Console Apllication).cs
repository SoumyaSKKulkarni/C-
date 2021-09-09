using System;
using BankAccount;
namespace MyAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount s1 = new SavingsAccount(5000, 5000, "soumya", 20368);
            ODAccount o1 = new ODAccount(500, 5.2f, 10000, 5000, "soumya", 20368);
            s1.Deposit(5000);
            s1.Withdraw(2000);
            o1.AddODInterest();
        }
    }
}
