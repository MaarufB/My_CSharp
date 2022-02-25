using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace constructor_injection
{
    public class Account
    {
        private IAccount _account;

        // Passing IAccount interface as parameter to Account constructor
        public Account(IAccount account)
        {
            _account = account;
        }

        public void PrintAccounts()
        {
            _account.PrintData();
        }
    }
}