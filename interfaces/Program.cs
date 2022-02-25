using System;

// By default the members of an interface are public. An interface can contain
// 1. Abstract methods
// 2. Properties
// 3. Indexes
// 4. Events

// An interface cannot contain
// 1. Non-Abstract functions
// 2. Data fields
// 3. Constructors
// 4. Destructors


namespace interfaces
{

    public interface A
    {
        void method1();
        void method2();
    }

    interface B : A 
    {
        void method3();
    }

    class MyClass : B
    {
        public void method1()
        {
            Console.WriteLine("Implement method1");
        }
        public void method2()
        {
            Console.WriteLine("Implement method2");
        }
        public void method3()
        {
            Console.WriteLine("Implement method3");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.method1();
            obj.method2();
            obj.method3();
            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }
    }
}
