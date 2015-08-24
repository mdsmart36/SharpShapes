using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class AQuadrilateral : AShape
    {
        public AQuadrilateral() : base() { }

        public AQuadrilateral(float side1, float side2, float side3, float side4)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
            this.Side4 = side4;
        }

        public float Side1 { get; set; }
        public float Side2 { get; set; }
        public float Side3 { get; set; }
        public float Side4 { get; set; }

        public abstract override float Area();
        public override float Perimeter()
        {
            if (Side1 == 0.0 || Side2 == 0.0 || Side3 == 0.0 || Side4 == 0.0)
            {
                throw new ArgumentException();
            }
            return Side1 + Side2 + Side3 + Side4;
        }
    }
}
