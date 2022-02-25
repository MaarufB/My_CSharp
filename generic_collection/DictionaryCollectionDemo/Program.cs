using System;
using System.Collections.Generic;

namespace DictionaryCollectionDemo
{

    // What is Dictionary?
    // The Dictionary in C# is a Collection class same as HashTable i.e. used to store the data in the form of Key Value Pairs, 
    // but here while creating the dictionary object you need to specify the type for the keys as well as the type for values also. 
    // The Syntax is given below:
    
    // Dictionary<TKey, TValue> di = new Dictionary<string, object>();
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary represents a collection of keys and values
            Dictionary<string, object> di = new Dictionary<string, object>();

            // adds the specified key and value to the dictionary
            di.Add("ID", 1001);    
            di.Add("Name", "Ma-aruf");    
            di.Add("Job", "Software Engineer");    
            di.Add("Salary", 7500);    
            di.Add("Location", "Pagadian");

            // Looping through each keys to get the values
            foreach(string key in di.Keys)
            {
                Console.WriteLine(key + " : " + di[key]);
            }        
            Console.WriteLine();

            // removes the specified key with the value from the dictionary
            Console.WriteLine("After removing the Job Key: ");
            di.Remove("Job");
            foreach(string key in di.Keys)
            {
                Console.WriteLine(key + " : " + di[key]);
            }
            Console.ReadKey();

        }
    }
}
