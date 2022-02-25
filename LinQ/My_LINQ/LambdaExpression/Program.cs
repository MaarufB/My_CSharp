using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaExpression
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {

            IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };



            // using Lambda with more than one expression
            var result = studentList.Where(s =>
            {
                int age = 13;
                return s.Age > age;
            });

            foreach (var r in result) Console.WriteLine($"{r.StudentName}");

            Console.ReadLine();
        }
    }
}
