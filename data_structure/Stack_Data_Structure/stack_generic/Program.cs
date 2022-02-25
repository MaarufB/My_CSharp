using System;
using System.Collections.Generic;

namespace stack_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> numbers = new Stack<string>();

            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");

            foreach(var item in numbers)
            {
                System.Console.WriteLine($"{item}");
            }

        }
    }
}
