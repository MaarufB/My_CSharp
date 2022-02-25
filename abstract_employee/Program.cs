using System;

// SUMMARY OF ABSTRACT CLASS AND ABSTRACT METHODS IN C#

// 1. A method that does not have a body is called an abstract method and the class that is declared by using the keyword abstract is called an abstract class.
// If a class contains an abstract method, then it must be declared as abstract
// 2. An abstract class can contain both abstract and non-abstract methods in it. If a child class of an abstract class wants to consume any non-abstract
// methods of its parent, should implement all abstract methods of its parent.
// 3. An abstract class is never usable to itself because we cannot create the object of an abstract class.
// The members of an abstract class can be consumed only by the child class of the abstract class.

namespace abstract_employee
{
    abstract class ClsEmployee
    {
        protected int EmpId, EAge;
        protected string EName, EAddress;
        public abstract void GetEmpData();
        public virtual void DisplayEmpData()
        {
            Console.WriteLine("Employee Id Is: " + this.EmpId); 
            Console.WriteLine("Employee Name Is: " + this.EName); 
            Console.WriteLine("Employee Address Is: " + this.EAddress); 
            Console.WriteLine("Employee Age Is: " + this.EAge); 
        }

        public ClsEmployee()
        {
            Console.WriteLine("ABSTRACT CLASS CONSTRUCTOR");
        }
    }
    class clsManager : ClsEmployee
    {
        double Bonus, CA;

        public override void GetEmpData()
        {
            Console.WriteLine("ENTER MANAGER DETAILS");
            Console.WriteLine("ENTER MANAGER ID: ");
            EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE MANAGER NAME: ");
            EName = Console.ReadLine();
            Console.WriteLine("ENTER THE MANAGER BONUS: ");
            Bonus = double.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THE MANAGER CA: ");
            CA = double.Parse(Console.ReadLine());
        }

        public override void DisplayEmpData()
        {
            Console.WriteLine("MANAGER ID IS: " + EmpId);
            Console.WriteLine("MANAGER NAME IS: " + EName);
            Console.WriteLine("MANAGER BONUS IS: " + Bonus);
            Console.WriteLine("MANAGER CA IS: " + CA);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ClsEmployee cm = new clsManager();
            cm.GetEmpData();
            cm.DisplayEmpData();
            Console.ReadKey();
        }
    }
}
