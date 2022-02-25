using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace abstraction
{
    public class PostgreSQL : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);
            output += " (From PostgreSQL)";
            return output;
        }
        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to PostgreSQL");
        }
        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading PostgreSQL Data");
        }
    }
}