using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using abstraction.Models;
using System.Text;

namespace abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DataAccess> databases = new List<DataAccess>()
            {
                new MySQL(),
                //new PostgreSQL()
            };

            foreach (var db_list in databases)
            {
                Console.WriteLine(db_list.LoadConnectionString("demo"));
            }
            List<EmployeeModel> emp = AddEmployee();

            foreach (var e in emp)
            {
                Console.WriteLine(e.FirstName);
            }
        }


        public static List<EmployeeModel> AddEmployee()
        {
            List<EmployeeModel> e = new List<EmployeeModel>();

            e.Add( new EmployeeModel { 
                                  FirstName = "Ma-aruf",
                                  LastName = "Burad", 
                                  Age = "23", 
                                  Address = "Cebu City",
                                  Salary = "Private"
                                });

            e.Add( new EmployeeModel { 
                                  FirstName = "Michael",
                                  LastName = "Jordan", 
                                  Age = "23", 
                                  Address = "Chicago",
                                  Salary = "10000"
                                  });

            e.Add( new EmployeeModel { 
                                  FirstName = "Rodrigo",
                                  LastName = "Duterte", 
                                  Age = "67", 
                                  Address = "Davao City",
                                  Salary = "1000000"
                                  });
            
            e.Add( new EmployeeModel { 
                                  FirstName = "Peter",
                                  LastName = "Parker", 
                                  Age = "34", 
                                  Address = "New York City",
                                  Salary = "5000"
                                  });
            
            return e;
        }
    }
}
