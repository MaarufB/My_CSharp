using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class _01_intro
    {
        int[] numbers = new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        public void RunSample()
        {
            // The three parts of LINQ Query
            // 1. Data Source
            //int[] numbers = new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            // 2. Query Creation
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // Query execution
            foreach(var num in numbers )
            {
                Console.Write("{0,1}", num);
            }
        }

        public void RunSample2()
        {
            // Forcing Immediate Execution
            var evenNumberQuery = 
                from num in numbers
                where(num % 2) == 0
                select num;

            int evenCount = evenNumberQuery.Count();
            Console.WriteLine($"Even Number counted is/are: {evenCount}");

            // Converting the data to ToArray or ToList

            var numQuery2 = 
                (from num in numbers
                 where (num % 2) == 0
                 select num).ToList();
            var count = 0;
            foreach(var num in numQuery2)
            {
                Console.WriteLine($"NumQuery2 item {count} is: {num}");
                count += 1;
            }
            //You can also force execution by putting the foreach loop immediately after the query expression. 
            //However, by calling ToList or ToArray you also cache all the data in a single collection object.
        }
    
    }
}
