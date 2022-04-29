using System.Collections.Generic;
using System;

namespace ComputerAverageApp
{

    
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 Grades separated by new line:");

            var grades = new List<double>();
            double totalScore = 0.0;

            for(int i = 0; i < 5; i++)
            {
                string num = Console.ReadLine();
                double new_num = Convert.ToDouble(num);
                grades.Add(new_num);
                totalScore += new_num;

            }

            var average = totalScore / grades.Count;
            var rounded_off = Math.Round(average);
            Console.WriteLine($"The Average is {average} and the round off to {rounded_off}");

            Console.ReadLine();
        }
    }
}
