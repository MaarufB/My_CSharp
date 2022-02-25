using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using abstraction.Models;

namespace abstraction
{
    public class Employee
    {
        
         public static List<EmployeeModel> AddEmployee()
        {
            List<EmployeeModel> e = new List<EmployeeModel>();

            e.Add( new EmployeeModel { 
                                  FirstName = "Ma-aruf",
                                  LastName = "Burad", 
                                  Age = "23", 
                                  Address = "Cebu City",
                                  Salary = "Private",
                                  Position = "Software Engineer"
                                });

            e.Add( new EmployeeModel { 
                                  FirstName = "Michael",
                                  LastName = "Jordan", 
                                  Age = "23", 
                                  Address = "Chicago",
                                  Salary = "10000",
                                  Position = "Basketball Player"
                                  });

            e.Add( new EmployeeModel { 
                                  FirstName = "Rodrigo",
                                  LastName = "Duterte", 
                                  Age = "67", 
                                  Address = "Davao City",
                                  Salary = "1000000",
                                  Position = "Philippine President"
                                  });
            
            e.Add( new EmployeeModel { 
                                  FirstName = "Peter",
                                  LastName = "Parker", 
                                  Age = "34", 
                                  Address = "New York City",
                                  Salary = "5000",
                                  Position = "Spider Man"
                                  });
            
            return e;
        }
    }
}