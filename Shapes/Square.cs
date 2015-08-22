using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Quadrilateral
    {
        public override float Area()
        {
            return this.side1 * this.side1;
        }

        public override float Perimeter()
        {
            return this.side1 * 4;
        }
    }
}
