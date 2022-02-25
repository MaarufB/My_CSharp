using System;
using System.Collections.Generic;

namespace StudentDataAccess
{
    class StudentDatabase
    {
        // Create an intance here to wrap the Student Model
        List<StudentModel> student = new List<StudentModel>();

        public List<StudentModel> AddStudentToDB()
        {
            student.Add( new StudentModel { Id = 1, FirstName = "Ma-aruf", LastName = "Burad"});
            student.Add( new StudentModel { Id = 2, FirstName = "Michael", LastName = "Jordan"});
            student.Add( new StudentModel { Id = 3, FirstName = "Stephen", LastName = "Curry"});
            student.Add( new StudentModel { Id = 4, FirstName = "Kyrie", LastName = "Irving"});
        }

        public List<StudentModel> GetStudentFromDB()
        {
            return student;
        }
    }

    class StudentModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // class Controller
    // {
    //     private readonly StudentDatabase _studentDB;
    //     public Controller(StudentDatabase studentDB)
    //     {
    //         _studentDB = studentDB;
    //     }


    //     // Add Student
    //     public void DisplayStudent()
    //     {
    //         List<StudentModel> students = _studentDB.GetStudentFromDB();
    //         foreach(var eachStudent in students)
    //         {   
    //             Console.WriteLine($"Student ID: { eachStudent.Id } FirstName { eachStudent.FirstName } LastName { eachStudent.LastName }");
    //         }
    //     }
    // }


    class Program
    {
        static readonly StudentDatabase _studentDB;
        static Program(StudentDatabase studentDB)
        {
            _studentDB = student;
        }

        static void DisplayStudent()
        {
            _studentDB.AddStudentToDB();
            List<StudentModel> students = _studentDB.GetStudentFromDB();
            foreach(var eachStudent in students)
            {   
                Console.WriteLine($"Student ID: { eachStudent.Id } FirstName { eachStudent.FirstName } LastName { eachStudent.LastName }");
            }
        }

        static void Main(string[] args)
        {
            DisplayStudent();
        }
    }
}
