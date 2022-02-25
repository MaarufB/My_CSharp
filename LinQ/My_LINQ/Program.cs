using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace My_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // This just a basic LINQ sample

            // Data source
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            // LINQ Query
            var myLinqQuery = from name in names where name.Contains('a') select name;

            // Query Execution
            foreach (var name in myLinqQuery) Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
