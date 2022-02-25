using System;
using System.Collections.Generic;

namespace Dictionary
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
            //Create Employee object
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 20000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 30000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 40000
            };
            // Create a Dictionary collection where 
            // Employee ID is the key and the key Type is int
            // Employee object is the value and the value Type is Employee
            Dictionary<int, Employee> dictionaryEmployees = new Dictionary<int, Employee>();

            // Add employee object to the dictionary collection
            // Employee ID is the key and the employee object is the value
            dictionaryEmployees.Add(emp1.ID, emp1);
            dictionaryEmployees.Add(emp2.ID, emp2);
            dictionaryEmployees.Add(emp3.ID, emp3);

            // Retrieve the value (i.e. Employee object) from the dictionary
            // using the key (i.e. Employee ID). 
            // The fastest way to get a value from the dictionary is by using its key
            Employee employee101 = dictionaryEmployees[101];
            Console.WriteLine("Employee 101 in employee dictionary");
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", employee101.ID, employee101.Name, employee101.Gender, employee101.Salary);
            Console.WriteLine();

            // It is also possible to loop tru each key/value pair in dictionary
            Console.WriteLine("All Employees keys and values in employee dictionary");
            foreach(KeyValuePair<int, Employee> employeeKeyValuePair in dictionaryEmployees)
            {
                Console.WriteLine("Key = " + employeeKeyValuePair.Key);
                Employee emp = employeeKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();

            // We can also use implicitly typed variable var to loop thru 
            // each key/value pair in a dictionary. 
            // But try to avoid using var, as this makes our code less readable
            Console.WriteLine("All employees keys and values in employee dictionary");
            foreach(var employeeKeyValuePair in dictionaryEmployees)
            {
                Console.WriteLine("Key = " + employeeKeyValuePair.Key);
                Employee emp = employeeKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();

            // To get all the keys in the dictionary we have to use the keys properties
            // of dictionaryCustomers object as shown below
            Console.WriteLine("All keys in employee dictionary");
            foreach(int key in dictionaryEmployees.Keys)
            {
                Console.WriteLine(key + " ");
            }
            Console.WriteLine();

            // First get the keys, the get the values using keys
            Console.WriteLine("All keys and values in Employee Dictionary");
            foreach(int key in dictionaryEmployees.Keys)
            {
                Console.WriteLine(key + " ");
                Employee emp = dictionaryEmployees[key];
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();

            // To get all the values in the dictionary use Values property
            Console.WriteLine("All Employee Objects in Employee Dictionary");
            foreach(Employee emp in dictionaryEmployees.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", emp.ID, emp.Name, emp.Gender, emp.Salary);
            }

             // If we try to add a key that already exists in the dictionary we will get an exception - 
            // An item with the same key has already been added. So, check if the key already exists
           // if(!dictionaryEmployees.ContainsKey(101))
            //{
             //   dictionaryEmployees.Add(101, emp1);
            //}
            //else
            //{
             //   Console.WriteLine("Key does not exist in the dictionary");
           // }
            Console.ReadKey();


        }
    }

    class Employee
    {
        public int ID { get; set; }     
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }     
    }
}
