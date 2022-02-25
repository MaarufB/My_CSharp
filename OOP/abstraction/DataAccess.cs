using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraction
{
    public abstract class DataAccess
    {
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection string");
            return "TestConnectionString";  
        }

        public abstract void LoadData(string sql);
        public abstract void SaveData(string sql);
    }
}

// The virtual keyword is used to modify a method, property, indexer, or event declaration and
// allow for it to be overridden in a derived class. For example, this method can be overridden
// by any class that inherits it.