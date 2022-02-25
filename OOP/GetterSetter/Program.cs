using System;
using GetterSetter;
namespace GetterSetter
{
    class Program
    {
        static void Main(string[] args)
        {
                // G, PG, PG-13, R, NR
        Movie avenger = new Movie("End Game", "Ma-aruf", "DOG");
        Movie spiderman =  new Movie("No Way Home!", "Petter Parker", "PG");

        Console.WriteLine($"This Avenger movie rating is {avenger.Rating}");
        Console.WriteLine($"This Spiderman movie rating is {spiderman.Rating}");
        

        }
    }
}
