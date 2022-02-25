using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class PostgreSQL
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);
            output += " (from postgreSQL)";
            return output;
        }
        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading PostgreSQL")
        }
        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to PostgreSQL");
        }
    }
}