using System;


namespace interfaces_area_triangle
{
    interface IShape
    {
        int GetArea();
        int GetPerimeter();
    }

    class Rectangle : IShape 
    {
        int length;
        int breadth;
        
        // Create a constructor
        public Rectangle(int l, int b)
        {   
            length = l;
            breadth = b;
        }

        public int GetArea()
        {
            return length * breadth;        
        }

        public int GetPerimeter()
        {
            return 2*(length + breadth);
        }
    }

    class Square : IShape
    {
        int side;

        // Create a contructor
        public Square(int s)
        {
            side = s;
        }

        public int GetArea()
        {
            return side * side;
        }

        public int GetPerimeter()
        {
            return 4*side;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(7, 4);
            Square s = new Square(4);

            Console.WriteLine("Rectangle : ");
            Console.WriteLine($"Area : { r.GetArea() } Perimeter : { r.GetPerimeter() }");

            Console.WriteLine("Square : ");
            Console.WriteLine($"Area : { s.GetArea() } Perimeter : { s.GetPerimeter() }");
        }
    }
}
