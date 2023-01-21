using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class _02_generic
    {
        public void RunSample()
        {
            var customers = new CustomerOperation().AddCustomer();

            IEnumerable<Customer> customerQuery =
                from cus in customers
                where cus.City == "Chicago"
                select cus;

            foreach (Customer customer in customerQuery) 
            {
                Console.WriteLine($"The queried customer is: {customer.FirstName}");
            }


            // Letting the compiler handle the generic type declarations
            var customerQuery2 =
                from cus in customers
                where cus.LastName == "Burad"
                select cus;

            foreach (Customer customer in customerQuery2) 
            {
                Console.WriteLine($"Customer Query from Generic type: {customer.FirstName}");
            }
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? City { get; set; }
    }

    public class CustomerOperation
    {
        public List<Customer> AddCustomer()
        {
            var customer = new List<Customer>() {
            new Customer() { Id = 1, FirstName="Ma-aruf", LastName="Burad", City="Cebu"},
            new Customer() { Id = 2, FirstName="Michael", LastName="Jordan", City="Chicago"}
            };

            return customer;
        }
    }
}
