using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeWithInterfaces
{
    class Rectangle : IQuadrilateral
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Perimeter { get; set; }
        public double Area { get; set; }

        public Rectangle()
        {

        }
        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
            Area = computeArea();
            Perimeter = computePerimeter();
        }

        public double computePerimeter()
        {
            return (2 * Width) + (2 * Height);
        }
        public double computeArea()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return $"This is a rectangle. It is {Width} wide, and {Height} tall." +
                $"\nThe area is: {Area}" +
                $"\nThe perimeter is {Perimeter}";
        }
    }
}

