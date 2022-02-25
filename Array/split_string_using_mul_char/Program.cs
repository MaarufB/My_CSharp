using System;

namespace split_string_using_mul_char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Split with multiple separators");
            // Split with multiple separators
            string multiCharString = "Mahesh..Chand, Henry\n He\t, Chris-Love, Raj..Beniwal, Praveen-Kumar";
            Console.WriteLine(multiCharString);
            // Split author separated by a comma followed space
            string[] multiArray = multiCharString.Split(new Char[] {' ', ',', '.', '-','\n', '\t'});
            foreach (string author in multiArray)
            {
                if(author.Trim() !="")
                    Console.WriteLine(author);
            } 
        }
    }
}
