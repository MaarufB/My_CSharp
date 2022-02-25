using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace constructor_injection
{
    // Inherit the property of IAccount and Implement it
    public class CurrentAccount : IAccount
    {
        public void PrintData()
        {
            Console.WriteLine("Current account");
        }
    }
}