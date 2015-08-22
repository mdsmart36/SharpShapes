using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle()
        {

        }

        public Rectangle(float length, float width)
        {
            this.Side1 = length;
            this.Side2 = width;
        }

        public override float Area()
        {
            return this.Side1 * this.Side2;
        }

        public override float Perimeter()
        {
            return (this.Side1 * 2) + (this.Side2 * 2);
        }
    }
}
