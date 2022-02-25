using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interface_console
{
    public interface IProductModel
    {
        string Title { get; set; }
        bool HasOrderBeenCompleted { get;}
        void ShipItem(CustomerModel customer);

        
    }
}