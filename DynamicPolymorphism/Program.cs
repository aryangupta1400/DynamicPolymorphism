
// 1) Calculate Area of the shape like circle, Square, Reactangle using dynamic polimorphism

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DynamicPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = 10;
            int length = 7, breadth = 10;
            int sideLen = 10;
            int output;

            Circle circle = new Circle(radius);
            output = circle.area();
            Console.WriteLine("\nArea of Circle is " + output);

            Square square = new Square(sideLen);
            output = square.area();
            Console.WriteLine("\nArea of Square is " + output);

            Rectangle rectangle = new Rectangle(length, breadth);
            output = rectangle.area();
            Console.WriteLine("\nArea of Rectangle is " + output);


            Console.WriteLine("\n\n Press any key to exit...");
            Console.ReadKey();

        }
    }

    abstract class Shape
    {
        public double PI = Math.PI;

        public abstract int area();
    }

    class Circle : Shape
    {
        private int radius;

        public Circle(int radius) // error if private/protected protection level used
        {
            this.radius = radius;
        }

        public override int area()
        {
            int circleArea = (int)(PI * radius * radius);

            return circleArea;
        }
    }

    class Square : Shape
    {
        private int sideLen;

        public Square(int sideLen) 
        {
            this.sideLen = sideLen;
        }

        public override int area()
        {
            int squareArea = sideLen * sideLen;

            return squareArea;
        }
    }

    class Rectangle : Shape
    {
        private int length, breadth;

        public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        
        public override int area()
        {
            int rectangleArea = length * breadth;

            return rectangleArea;
        }
    }

}

