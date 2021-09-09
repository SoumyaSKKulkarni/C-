using System;

namespace BankAccount
{
    interface IInterfaceCalculator
    {
        void AddInterest();
    }
    abstract public class BankAccount
    {
        public static double balanceAmount;
        public string accountHolderName;
        public int accountNumber;

        public BankAccount(double x, string y, int z)
        {
            balanceAmount = x;
            accountHolderName = y;
            accountNumber = z;
           
            Console.WriteLine();
        }

        public virtual void Deposit(double amount)
        {
            balanceAmount += amount;
        }

        abstract public void Withdraw(double amount);

    }
    class MinimumBalanceException : ApplicationException
    {
        public MinimumBalanceException() : base("Your balance will be less than 500 rupees if you withdraw. Kindly maintain balance.")
        {

        }
    }
     public class  SavingsAccount : BankAccount, IInterfaceCalculator
     {
        double minimumBalance;
        double interest = 10;
        public void AddInterest()
        {
            balanceAmount += balanceAmount*interest / 100;
        }
        public SavingsAccount(double min, double x, string y, int z) : base(x, y, z)
        {
            minimumBalance = min;
            Console.WriteLine("SavingsAccount");
            Console.WriteLine("Minimum Balance :" + minimumBalance);
            Console.WriteLine();
        }
        public override void Withdraw(double amount)
        {
            double amt = minimumBalance - amount;
            try
            {
                if (amt < 500)
                {
                    throw new MinimumBalanceException();
                }
                else
                {
                    balanceAmount -= amount;
                    Console.WriteLine("Withdrawal success in Savings account. Total balance is "+balanceAmount);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }
        public override void Deposit(double amount)
        {
            balanceAmount += amount;
            Console.WriteLine("Amount deposited in Savings Account.Total balance is " + balanceAmount);
        }

    }
    public class ODAccount : BankAccount
    {
        double minimumBalance;
        float ODInterest;
        double ODLimit;
        public ODAccount(double mb, float interest, double limit, double x, string y, int z) : base(x, y, z)
        {
            minimumBalance = mb;
            ODInterest = interest;
            ODLimit = limit;
            Console.WriteLine("ODAccount");
            Console.WriteLine($"MinimumBalance-{minimumBalance}\tODInterest-{ODInterest}\tODLimit-{ODLimit}");
        }

        public void AddODInterest()
        {
            balanceAmount += balanceAmount*ODInterest / 100;
            Console.WriteLine("Interest added to OD account");
        }
        public override void Withdraw(double amount)
        {
            double amt = minimumBalance - amount;
            try
            {
                if (amt < 500)
                {
                    throw new MinimumBalanceException();
                }
                else
                {
                    balanceAmount -= amount;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
