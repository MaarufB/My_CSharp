using System;
using System.Collections.Generic;


namespace LinkedList_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a linkedlist
            // Using LinkedList class
            LinkedList<string> my_list = new LinkedList<string>();


            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast("Noraya");
            my_list.AddLast("Hanerah");
            my_list.AddLast("Ta-arif");
            my_list.AddLast("Shahannah");
            my_list.AddLast("Azzarif");
            my_list.AddFirst("Ma-aruf");

            Console.WriteLine($"Best family of satah");

            foreach(var str in my_list)
            {
                Console.WriteLine($"{str}");
            }

            LinkedList<MyClassList> myList = new LinkedList<MyClassList>();

            myList.AddLast(new MyClassList { FirstName = "Ma-aruf", LastName = "Burad", Next = null, Previous = null });


            foreach(var list in myList)
            {
                Console.WriteLine($"{list.FirstName} {list.LastName}, {list.Next}, {list.Previous}");
            }




            Console.ReadLine();

        }
    }
}
