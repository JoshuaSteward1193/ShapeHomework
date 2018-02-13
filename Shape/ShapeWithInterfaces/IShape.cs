using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeWithInterfaces
{
    interface IShape
    {
        double Perimeter { get; set; }
        double Area { get; set; }

        double computeArea();
        double computePerimeter();
    }
}
