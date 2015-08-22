using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Rectangle
    {
        public Square(float side1)
        {
            this.Side1 = side1;
        }

        public override float Area()
        {
            return this.Side1 * this.Side1;
        }

        public override float Perimeter()
        {
            return this.Side1 * 4;
        }
    }
}
