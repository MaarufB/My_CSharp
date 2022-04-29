﻿using System;

namespace constructor_instance
{
    abstract class Shape
    {
        public const double pi = Math.PI;
        protected double x, y;
        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double Area();

    }

    class Circle : Shape
    {
        public Circle(double radius) : base(radius, 0)
        {

        }

        public override double Area()
        {
            return pi * x * x;
        }
    }

    class Cylinder : Circle
    {
        public Cylinder(double radius, double height):base(radius)
        {

        }

        public override double Area()
        {
            return (2* base.Area()) + (2*pi*x*y);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            double radius = 2.5;
            double height = 3.0;

            var ring = new Circle(radius);
            Console.WriteLine($"Area of the circle = {ring.Area():F2}");
            // Output: Area of the circle = 19.63
            
            var tube = new Cylinder(radius, height);
            Console.WriteLine($"Area of the cylinder = {tube.Area():F2}");
            // Output: Area of the cylinder = 86.39
        }
    }
}