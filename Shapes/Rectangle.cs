using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : AQuadrilateral
    {
        // constructors
        
        public Rectangle(float length, float width) : base( length, width, length, width) { }
        public Rectangle() : base() { }

        // methods
        public override float Area()
        {
            if (Side1 == 0 || Side2 == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return this.Side1 * this.Side2;
            }
        }

        public override float Perimeter()
        {
            if (Side1 == 0 || Side2 == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return (this.Side1 * 2) + (this.Side2 * 2);
            }
        }
    }
}
