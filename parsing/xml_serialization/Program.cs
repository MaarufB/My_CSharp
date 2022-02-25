using System;
using System.Xml.Serialization;
using System.IO;


namespace xml_serialization
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Subject { get; set; }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Id = 1;
            e.Name = "Ma-aruf";
            e.Subject = "Programming";

            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            TextWriter txtWriter = new StreamWriter("test.xml");

            xs.Serialize(txtWriter, e);
            txtWriter.Close();
        }

    }
}
