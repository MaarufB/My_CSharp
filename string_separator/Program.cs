using System;

namespace string_separator
{
    // ADD SEPARATOR
    // Given a string and separator, write a method that adds separator between each adjacent character string

    class Program
    {
        static string AddSeparator(string word, string separator)
        {
            string separatedWord = string.Empty;
            for (int i = 0; i < word.Length - 1; i++)
            {
                separatedWord += i < word.Length - 1 ? word[i] + separator : word[i].ToString();
            } 
            return separatedWord;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AddSeparator("MotherFucker", "_"));   
            Console.WriteLine(AddSeparator("Yawaka", "+"));
        }
    }
}
