﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Circle : Shape
    {
        double Radius { get; set; }

        public Circle(double r)
        {
            Radius = r;
            Area = computeArea();
            Perimeter = computePerimeter();
        }
        public override double computeArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double computePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return $"This is a circle with a radius of {Radius}." +
                $"\nThe area of the circle is: {Area}" +
                $"\nThe perimeter (or circumference) of the circle is: {Perimeter}";
        }
    }
}
