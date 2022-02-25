using System;

namespace MethodInjection
{
    public interface IAccount
    {
        void PrintData(); // A contract
    }

    public class SavingAccount : IAccount
    {
        public void PrintData()
        {
            Console.WriteLine("Print the Saving Account Data!");
        }
    }

    public class CurrentAccount : IAccount
    {
        public void PrintData()
        {
            Console.WriteLine("Print the Current Account Data!");
        }
    }

    public class Account
    {
        // Passing "IAccount" as a parameter to PrintAccount() Method
        public void PrintAccounts(IAccount account)
        {
            account.PrintData();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            // This is for the SavingAccount
            Account savingAccount = new Account();
            savingAccount.PrintAccounts(new SavingAccount());

            // This is for the CurrentAccount
            Account currentAccount = new Account();
            currentAccount.PrintAccounts(new CurrentAccount());

            Console.ReadLine();
        }
    }
}
