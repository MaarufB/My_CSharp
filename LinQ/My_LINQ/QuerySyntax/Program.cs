using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuerySyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> stringList = new List<string>()
            {
                "C#",
                "VB.NET",
                "JAVA",
                "Python",
                "Javascript",
                "TypeScript"
            };


            // Linq query syntax

            var result = from s in stringList where s.Contains("a") select s;

            foreach (var r in result) Console.WriteLine(r);


            Console.ReadLine();
        }
    }
}
