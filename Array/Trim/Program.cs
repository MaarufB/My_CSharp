using System;

namespace Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello C# Corner has white spaces ";
            //Remove whitespaces from both ends
            Console.WriteLine(hello.Trim());

            // String with characters
            string someString = "...... My name is Ma-aruf Burad*********";
            char[] charToTrim = {'*','.'};
            string cleanString = someString.Trim(charToTrim);
            Console.WriteLine(cleanString); 
            Console.WriteLine(cleanString.Trim(' '));

            // Using String.TrimStart() method
            // Removes all leading occurences of a set of characters specified in an array from the current string

            Console.WriteLine("\n");
            Console.WriteLine("This Part here is for using String.TrimStart() method");

            string trimStart = cleanString.TrimStart(charToTrim);
            Console.WriteLine(trimStart);

            Console.WriteLine("\n");
            Console.WriteLine("This Part here is for using String.TrimEnd() method");

            //String.TrimEnd() method removes all trailing occurrences of a set 
            //of characters specified in an array from the current String object.

            string trimEnd = cleanString.TrimEnd(charToTrim);
            Console.WriteLine(trimEnd);
        }
    }
}
