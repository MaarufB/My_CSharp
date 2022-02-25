using System;
using System.Collections.Generic;


namespace simple_dictionary
{

    class StudentDatabase
    {
        // This is the database
        public List<StudentModel> studentList;
        private StudentModel _student;
        public StudentDatabase(StudentModel student)
        {
            _student = student;
        }
    }

    class StudentModel
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
    }   

    class StudentLogic
    {
        Dictionary<string, List<string>> studentDict = new Dictionary<string, List<string>>();
        List<StudentModel> student = new List<StudentModel>();
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
