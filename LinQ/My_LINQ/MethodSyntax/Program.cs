using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodSyntax
{
    class Student
    {
        public int StudentID { get; set; }
        public string  StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // string collection
            IList<string> stringList = new List<string>() {
                "C# Tutorials",
                "VB.NET Tutorials",
                "Learn C++",
                "MVC Tutorials" ,
                "Java"
            };

            // LINQ Query Syntax using method

            var result = stringList.Where(s => s.Contains('a'));

            foreach (var r in result) Console.WriteLine(r);




            // Student collection
            IList<Student> studentList2 = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
            new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            var teenagerStudents = studentList2.Where(s => s.Age > 12 && s.Age < 20).ToList();
            Console.WriteLine("Using Method in LINQ");
            foreach (var t in teenagerStudents) Console.WriteLine($"{t.StudentName}");

            Console.ReadLine();
        }
    }
}
