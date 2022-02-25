using System;

namespace constructor_injection
{
    class Program
    {
        static void Main(string[] args)
        {
            // If you want to call the SavingAccount class PrintAccounts() method,
            // 

            IAccount savingAccount = new SavingAccount();
            Account account = new Account(savingAccount);
            account.PrintAccounts();

            // If you just want to print the current account class. PrintAccounts() method

            IAccount currentAccount = new CurrentAccount();
            account = new Account(currentAccount);
            account.PrintAccounts();
            Console.ReadLine();
        }
    }
}
