using System;

namespace split_string_into_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comma Separated strings");
            
            // String authors
            string authors = "Mahesh Chand, Henry He, Chris Love, Raj Beniwal, Praveen Kumar";
            Console.WriteLine(authors);

            // Split authors separated by a comma followed by space
            string[] authorList = authors.Split(", ");
            
            foreach(var author in authorList)
                Console.WriteLine(author);
        }
    }
}
