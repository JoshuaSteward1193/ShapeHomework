using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Square : Rectangle
    {
        public Square(double sl)
        {
            Width = sl;
            Height = sl;
            Area = computeArea();
            Perimeter = computePerimeter();
        }        
        public override string ToString()
        {
            return $"This is a square with all sides equal to {Width}." +
                $"\nThe area of the square is: {Area}" +
                $"\nThe perimeter of the square is: {Perimeter}";
        }
    }
}
