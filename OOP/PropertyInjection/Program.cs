using System;

namespace PropertyInjection
{
    public interface IAccount
    {
        void PrintData(); // A contract
    }

    public class SavingAccount : IAccount
    {
        // What are we gonna do here is to implement the IAccount Interface for our SavingAccount Class
        public void PrintData()
        {
            Console.WriteLine("Saving Accoung Data!");
        }
    }

    public class CurrentAccount : IAccount
    {
        // What are we gonna do here is to implement the IAccount Interface for our CurrentAccount Class
        public void PrintData()
        {
            Console.WriteLine("Current Account Data!");
        }
    }


    // Now let create our Account Class
    public class Account
    {
        public IAccount account { get; set; }
        
        public void PrintAccounts()
        {
            account.PrintData();
        }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            Account savingAccount = new Account();
            savingAccount.account = new SavingAccount();
            savingAccount.PrintAccounts(); // Prints the Saving Account Data


            // For our Current Account
            Account currentAccount = new Account();
            currentAccount.account = new CurrentAccount();
            currentAccount.PrintAccounts(); // It prints the Current Account Data
            
            Console.ReadLine();
        }
    }
}
