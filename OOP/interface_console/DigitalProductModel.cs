using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interface_console
{
    public class DigitalProductModel : IDigitalProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted {get; private set;}
        public int TotalDownloadsLeft {get; private set;} = 5;
        public void ShipItem (CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing { Title } to {customer.FirstName} in {customer.City}");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
        
    }
}