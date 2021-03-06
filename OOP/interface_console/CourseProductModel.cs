using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interface_console
{
    public class CourseProductModel : IProductModel
    {
        public string Title { get ; set ; }

        public bool HasOrderBeenCompleted {get;  private set;}

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Added the { Title } course to { customer.FirstName }'s account.");
                HasOrderBeenCompleted = true;
            }
        }
    }
}