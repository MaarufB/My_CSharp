using System;

namespace split_string_delimited
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Split String delimited by another string");

            string stringString = "Mahesh Chand, Neel Chand Beniwal, Raj Beniwal, Dinesh Beniwal";

            //String separator
            string[] stringSeparator = new string[] {"Beniwal", "Chand, " };
            string[] firstNames = stringString.Split(stringSeparator, StringSplitOptions.None);

            foreach(string firstName in firstNames)
            {

                Console.WriteLine(firstName);
            }

        }
    }
}
