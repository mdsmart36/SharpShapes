using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Quadrilateral : Shape
    {
        public float side1 { get; set; }
        public float side2 { get; set; }
        public float side3 { get; set; }
        public float side4 { get; set; }

        public abstract override float Area();
        public override float Perimeter()
        {
            return this.side1 + this.side2 + this.side3 + this.side4;
        }
    }
}
