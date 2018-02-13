using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeWithInterfaces
{
    interface IQuadrilateral : IShape
    {
        //I could think of nothing that a quadrilateral has that a shape doesnt have.
        //A rectangle also needs nothing from a quadrilateral, since they both have 4 sides.
    }
}
