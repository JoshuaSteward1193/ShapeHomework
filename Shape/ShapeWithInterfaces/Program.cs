using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeWithInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program creates shapes via classes with interfaces, and tests them.");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Creating and printing a triangle:");
            Triangle triangle = new Triangle(3, 6, 8);
            Console.WriteLine(triangle.ToString());
            Console.WriteLine("");
            Console.WriteLine("Creating and printing a rectangle:");
            Rectangle rectangle = new Rectangle(5, 2);
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine("");
            Console.WriteLine("Creating and printing a circle:");
            Circle circle = new Circle(4);
            Console.WriteLine(circle.ToString());
            Console.WriteLine("");
            Console.WriteLine("Creating and printing a square:");
            Square square = new Square(5);
            Console.WriteLine(square.ToString());
            Console.ReadKey();
        }
    }
}
