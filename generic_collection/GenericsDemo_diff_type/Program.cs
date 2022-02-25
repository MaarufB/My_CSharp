using System;

namespace GenericsDemo_diff_type
{
    // THIS IS NOT A GENERIC TYPE! WE NEED TO COMPARE TWO APPROACHES USING GENERIC AND NON-GENERIC 
    class Program
    {
        static void Main(string[] args)
        {
            bool IsEqual = ClsCalculator.IsEqual(10.5, 20.5);
            if(IsEqual)
            {
                Console.WriteLine("Both are equal!");
            }
            else{
                Console.WriteLine("Both are not equal!");
            }
        }
    }

    public class ClsCalculator
    {
        public static bool IsEqual(int value1, int value2)
        {
            return value1 == value2;
        }

        public static bool IsEqual(string value1, string value2)
        {
            return value1 == value2;
        }

        public static bool IsEqual(double value1, double value2)
        {
            return value1 == value2;
        }
    }
}
