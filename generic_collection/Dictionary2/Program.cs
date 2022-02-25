using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary2
{
    public class Program
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

            // Add Employee objects to the dictionary collection
            // Employee ID is the key and the employee object is the value
            dictionaryEmployees.Add(emp1.ID, emp1);
            dictionaryEmployees.Add(emp2.ID, emp2);
            dictionaryEmployees.Add(emp3.ID, emp3);

            // If you are not sure if a key is present or not in the dictionary, 
            // then you can use the TryGetValue() method to get the value from a dictionary because 
            // if you are not using TryGetValue then at that case you will get KeyNotFoundException
            Employee emp777;
            if (dictionaryEmployees.TryGetValue(777, out emp777))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp777.ID, emp777.Name, emp777.Gender, emp777.Salary);
            }
            else
            {
                Console.WriteLine("Employee with Key = 777 is not found in the dictionary");
                Console.WriteLine();
            }

            // To find the total number of items in a dictionary use Count() method
            Console.WriteLine("Total items in Employee Dictionary = {0}", dictionaryEmployees.Count());
            // Or You can use the Count Property
            // Console.WriteLine("Total items in Employee Dictionary = {0}", dictionaryEmployees.Count);
            Console.WriteLine();

            // LINQ extension methods can also be used with the Dictionary. 
            // For example, to find the total employees whose Gender is Male.
            Console.WriteLine("Total Employees in the dictionary where Gender is Male = {0}",
                              dictionaryEmployees.Count(kvp => kvp.Value.Gender == "Male"));
            Console.WriteLine();

            // To remove an item from the dictionary, use Remove() method
            dictionaryEmployees.Remove(101);

            // To remove all items from the dictionary, use Clear() method
            dictionaryEmployees.Clear();

            //Now our dictionary is empty

            // Create an array of employees with size 3
            // Store the 3 employees into the array
            Employee[] arrayEmployees = new Employee[3];
            arrayEmployees[0] = emp1;
            arrayEmployees[1] = emp2;
            arrayEmployees[2] = emp3;

            // Convert Employee array to a dictionary using ToDictionary() method.
            // In this example, key is Employee ID and the value is the employee object itself
            Dictionary<int, Employee> dict = arrayEmployees.ToDictionary(employee => employee.ID, employee => employee);
            // OR        
            // Dictionary<int, Employee> dict = arrayEmployees.ToDictionary(employee => employee.ID);
            //OR use a foreach loop
            //Dictionary< int, Employee> dict = new Dictionary<int, Employee>();
            //foreach (Employee emp in arrayEmployees)
            //{
            //    dict.Add(emp.ID, emp);
            //}

            // Loop thru the dictionary and print the key/value pairs
            foreach (KeyValuePair<int, Employee> kvp in dict)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Employee emp = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}