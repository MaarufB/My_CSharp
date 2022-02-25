using System;
using System.Collections.Generic;

namespace interface_console
{
    class Program
    {

        // Interface is a contract, whoever who implement that contract needs to have a signature
        // on interface class
        // 
        static void Main(string[] args)
        {
            List<IProductModel> cart =  AddSampleData();
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                Console.WriteLine($"Iproduct members {prod}");
                prod.ShipItem(customer);
                
                if (prod is IDigitalProductModel digital)
                {
                    Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } download left!");
                }
                
            }
            Console.ReadLine();
        }


        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Ma-aruf",
                LastName = "Burad",
                City = "Cebu",
                EmailAddress = "maarufburad1231@gmail.com",
                PhoneNumber = "09100116627"
            };
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();
            output.Add(new PhysicalProductModel { Title = "Nerf Football"});
            output.Add(new PhysicalProductModel { Title = "IAmMa-aruf T-Shirt"});
            output.Add(new PhysicalProductModel { Title = "Hard Drive"});
            output.Add(new DigitalProductModel { Title = "Lesson Source Code"});
            output.Add(new CourseProductModel { Title = ".NET Core Start to Finish"});

            return output;
        }
    }
}
