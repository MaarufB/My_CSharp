using System;
using System.Collections.Generic;

namespace GenericsDemo
{
    // THIS IS NOT A GENERIC TYPE! WE NEED TO COMPARE TWO APPROACHES USING GENERIC AND NON-GENERIC
    class Program
    {
        static void Main(string[] args)
        {
            bool IsEqual = Calculator.AreEqual(10, 20);
            if(IsEqual)
            {
                Console.WriteLine("Both are equal!");
            }
            else
            {
                Console.WriteLine("Both are not equal!");
            }
            Console.ReadKey();
        }
    }

    public class Calculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }
    }
}
