using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeWithInterfaces
{
    class Triangle : IShape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Perimeter { get; set; }
        public double Area { get; set; }

        public Triangle(double s1, double s2, double s3)
        {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
            Area = computeArea();
            Perimeter = computePerimeter();
        }

        public double computeArea()
        {
            //If one side of the triangle is longer than the sum of the other two, Heron's formula catches it and returns NaN.
            double semiperimeter = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - Side1) * (semiperimeter - Side2) * (semiperimeter - Side3));
        }
        public double computePerimeter()
        {
            return Side1 + Side2 + Side3;
        }
        public override string ToString()
        {
            return $"This is a triangle with sides that measure {Side1}, {Side2}, and {Side3}, respectively." +
                $"\nThe area of the triangle is: {Area}" +
                $"\nThe perimeter of the triangle is: {Perimeter}";
        }
    }
}
