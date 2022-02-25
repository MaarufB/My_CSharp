using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interface_console
{
    public interface ICustomerModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string City { get; set; }
        string EmailAddress { get; set; }
        string PhoneNumber { get; set; }
    }

    public class CustomerModel : ICustomerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}