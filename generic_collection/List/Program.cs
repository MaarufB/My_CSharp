using System;
using System.Collections.Generic;

namespace List
{

    // Note: All the generic classes in C# are strongly typed. That means if we have created a List of type Employees,
    // then we can only add objects of type Employees into the list. If we try to add an object of a different type, 
    //then we will get a compile-time error.
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee Object
            Employee emp1  = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 5000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 7000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 5500
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Male",
                Salary = 6500
            };

            // Create a List of Employees
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(emp1);    
            listEmployees.Add(emp2);    
            listEmployees.Add(emp3);

            // We can retrieve the Items from a list collection by using index.
            // The following line of code will retrieve the employee from the list.
            // The List index is also based 0

            Employee emp = listEmployees[0];
            
            Console.WriteLine("Retrieve the first employee by index.");
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", emp.ID, emp.Name, emp.Gender, emp.Salary);
            Console.WriteLine();

            // retrieve the list using loop
            Console.WriteLine("Retrieving the list using for loop.");
            for(int i = 0; i < listEmployees.Count; i++)
            {
                Employee employee = listEmployees[i];
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            Console.WriteLine();

            // retrieving an employee using foreach loop
            foreach(Employee e in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", e.ID, e.Name, e.Gender, e.Salary);
            }
            Console.WriteLine();

            // Inserting an employee into the index position 1
            listEmployees.Insert(1, emp4);
            // Retrieving the list after inserting the employee index position 1
            Console.WriteLine("Retrieving the list after inserting the employee index position 1.");
            foreach(Employee e in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", e.ID, e.Name, e.Gender, e.Salary);
            }
            Console.WriteLine();

            // If you want to get the index position of a specific employee
            // the use IndexOf() method as shown below
            Console.WriteLine("Index of emp3 object in the List = " + listEmployees.IndexOf(emp3));
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
