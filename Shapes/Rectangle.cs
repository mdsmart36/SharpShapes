using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        public override float Area()
        {
            return this.side1 * this.side2;
        }

        public override float Perimeter()
        {
            return (this.side1 * 2) + (this.side2 * 2);
        }
    }
}
