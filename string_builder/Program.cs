using System;
using System.Text;
namespace string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This example here is for c# string builder!");
            
            StringBuilder builder = new StringBuilder("Ma-aruf");
            builder.Append(",");
            builder.Append("Pulmano bugo");
            builder.Append(",SoySoy");

            Console.WriteLine(builder);

        }
    }
}
