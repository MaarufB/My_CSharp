using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loop
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {

            List<Student> studentList = new List<Student>();

            studentList.Add(new Student { StudentId = 1, StudentName = "Ma-aruf", Age = 23 });
            studentList.Add(new Student { StudentId = 2, StudentName = "Steve", Age = 20 });
            studentList.Add(new Student { StudentId = 3, StudentName = "Bill", Age = 25 });
            studentList.Add(new Student { StudentId = 4, StudentName = "Mark", Age = 21 });
            studentList.Add(new Student { StudentId = 5, StudentName = "Juan", Age = 13 });
            studentList.Add(new Student { StudentId = 6, StudentName = "Pedro", Age = 15 });
            studentList.Add(new Student { StudentId = 7, StudentName = "Pendiko", Age = 18 });
            studentList.Add(new Student { StudentId = 8, StudentName = "Andress", Age = 11 });

            Student[] teenAgerStudents = studentList.Where(s => s.Age > 12 && s.Age < 20).ToArray();
            Console.WriteLine("Teen Ager Students");
            foreach (var s in teenAgerStudents) Console.WriteLine($"{s.StudentName}");

            // Use Linq to find the first student whose name is Ma-aruf
            Student ma_aruf = studentList.Where(s => s.StudentName == "Ma-aruf").FirstOrDefault();
            Console.WriteLine($"The first student is {ma_aruf.StudentName}");

            // Use Linq to find student whose StudentID is 1
            Student id5 = studentList.Where(s => s.StudentId == 1).FirstOrDefault();
            Console.WriteLine($"Querying using id and found is: {id5.StudentName}");

            Console.ReadLine();

        }
    }
}
