using System;
using override_virtual;
// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords

namespace override_virtual
{

    class BaseClass
    {
        public virtual void Method1()
        {
            System.Console.WriteLine($"Base - Method 1");
        }

        public void Method2()
        {
            System.Console.WriteLine($"Base - Method 2");
        } 
    }

    class DerivedClass:BaseClass
    {
        public override void Method1()
        {
            System.Console.WriteLine($"Derived - Method 1");
        }

        // we need to add new keywork 
        public new void Method2()
        {
            System.Console.WriteLine($"Derived - Method 2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        // BaseClass bc = new BaseClass();  
        // DerivedClass dc = new DerivedClass();  
        // BaseClass bcdc = new DerivedClass();  
    
        // bc.Method1();  
        // bc.Method2();  
        // dc.Method1();  
        // dc.Method2();  
        // bcdc.Method1();  
        // bcdc.Method2();  

            // bc.Method1(); // invoke Method 1 from base class
            // dc.Method1(); // invoking Method 1 using the instance of DerivedClass
            // dc.Method2(); // invoking Method 2 using the instace of Derived class
            // bcdc.Method1(); // invoking Method 1 by the instance of Derived Class and type of BaseClass


        var carShow = new CarProgramClass();
        // carShow.RunProgram();
        // carShow.RunProgram2();
        carShow.RunProgram3();
        carShow.RunProgram4();

        }
    }
}


//https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords