using System;

namespace abstract_electricity_bill
{

    public abstract class Plan
    {
        protected double rate;
        public abstract void getRate();
        public void calculation(int units)
        {
            Console.WriteLine("Bill Amount FOR " + units + " UNITS is: Rs.");
            Console.WriteLine(rate * units);
        }
    }

    class CommercialPlan : Plan
    {
        public override void getRate()
        {
            rate = 5.00;
        }
    }

    class DomesticPlan : Plan
    {
        public override void getRate()
        {
            rate = 2.50;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Plan p;
            Console.WriteLine("COMMERCIAL CONNECTION");
            p = new CommercialPlan();
            p.getRate();
            p.calculation(250);
            Console.WriteLine("DOMESTIC CONNECTION");
            p = new DomesticPlan();
            p.getRate();
            p.calculation(150);
            Console.ReadKey();
        }
    }
}
