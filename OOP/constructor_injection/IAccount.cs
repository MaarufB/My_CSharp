using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace constructor_injection
{
    public interface IAccount
    {
        void PrintData();
        // This is a contract and it needs to be implemented 
        // to the derived class. This is the base class/Interface and we need a 
        // derived class to implement the PrintData!
    }
}