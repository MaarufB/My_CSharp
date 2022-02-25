using System;

namespace replace_string
{
    class Program
    {
        static void Main(string[] args)
        {
            /** Replace sample **/  
            // Replace a char  
            string odd = "1, 3, 5, 7, 9, 11, 13, 15, 17, 19";  
            Console.WriteLine("Original odd: {odd}");  
            string newOdd = odd.Replace(',', ':');  
            Console.WriteLine("New Odd: {newOdd}");  
            string authors = "Mahesh Beniwal, Neel Beniwal, Raj Beniwal, Dinesh Beniwal";  
            Console.WriteLine("Authors with last names: {authors}");  
            // Remove all Beniwal with space and remove space with empty string  
            string firstNames = authors.Replace(" Beniwal", "");  
            Console.WriteLine("Authors without last names: {firstNames}");  
            Console.ReadKey();  
        }
    }
}
