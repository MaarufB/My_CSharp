using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interface_console
{
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadsLeft { get;}
    }
}