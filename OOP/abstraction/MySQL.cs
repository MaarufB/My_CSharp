using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraction
{
    public class MySQL : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);
            output += " (from MySQL)";
            return output;
        }
        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading MySQL Data");
        }
        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving Data to MySQL");
        }
    }
}