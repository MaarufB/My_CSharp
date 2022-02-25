using System;
using System.Collections.Generic;

namespace override_virtual
{

    // Define the base class, Car. The class defines two methods,  
    // DescribeCar and ShowDetails. DescribeCar calls ShowDetails, and each derived  
    // class also defines a ShowDetails method. The example tests which version of  
    // ShowDetails is selected, the base class method or the derived class method. 
    public class CarBase
    {
        public void DescribeCar()
        {
            System.Console.WriteLine($"CarBase DescribeCar: Four wheels and an engine.");
            ShowDetails();
        }

        public virtual void ShowDetails()
        {
            System.Console.WriteLine($"CarBase ShowDetails: Standard transportation.");
        }
    }

    // Define the derived classes.  
    
    // Class ConvertibleCar uses the new modifier to acknowledge that ShowDetails  
    // hides the base class method.
    class ConvertibleCar:CarBase
    {
            // As we can notice from the output. The ShowDetails in this class won't be invoked if we put a modefier as new. But if we try ovveride it will override th
            // virtual method from the base class

        public new void ShowDetails()
        {
            System.Console.WriteLine($"Convertible ShowDetails: A roof that opens up.");
        }
    }

    // Class Minivan uses the override modifier to specify that ShowDetails  
    // extends the base class method.  
    class MiniVan: CarBase
    {
        public override void ShowDetails()
        {
            System.Console.WriteLine($"MiniVan ShowDetails: Carries seven people.");
            // base.ShowDetails();
        }
    }

    public class CarProgramClass
    {
        public void RunProgram()
        {
            Console.WriteLine($"\nTestCar1");
            System.Console.WriteLine($"----------");

            CarBase car1 = new CarBase();

            car1.DescribeCar();
            System.Console.WriteLine($"---------------");

            // Notice the output from this test case. The new modifier is  
            // used in the definition of ShowDetails in the ConvertibleCar  
            // class.

            ConvertibleCar car2 = new ConvertibleCar();
            car2.DescribeCar();
            System.Console.WriteLine($"-----------------");

            MiniVan car3 = new MiniVan();
            car3.DescribeCar();

            System.Console.WriteLine($"------------------");

        }

        public void RunProgram2()
        {
            Console.WriteLine($"\nTestCars2");
            Console.WriteLine($"-----------");

            var cars = new List<CarBase>
            {
                new CarBase(),
                new ConvertibleCar(),
                new MiniVan()
            };

            foreach(var car in cars)
            {
                car.DescribeCar();
                Console.WriteLine($"------------------");
            }
        }


        public void RunProgram3()
        {
            Console.WriteLine($"\nTestCars");
            Console.WriteLine($"-------------------");
            ConvertibleCar car2 = new ConvertibleCar();
            MiniVan car3 = new MiniVan();
            car2.DescribeCar();
            car3.DescribeCar();
        }

        public void RunProgram4()
        {
            Console.WriteLine($"\nTestCar4");
            Console.WriteLine("$------------");
            CarBase car2 = new ConvertibleCar();
            CarBase car3 = new MiniVan();
            car2.DescribeCar();
            car3.DescribeCar();

            
        }
    }
}