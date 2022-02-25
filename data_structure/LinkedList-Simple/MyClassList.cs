using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Simple
{
    public class MyClassList
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public MyClassList Next { get; set; }
        public MyClassList Previous { get; set; }
    }
}
