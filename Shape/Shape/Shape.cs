using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    abstract class Shape
    {
        public double Perimeter { get; set; }
        public double Area { get; set; }

        public abstract double computeArea();
        public abstract double computePerimeter();
    }
}
