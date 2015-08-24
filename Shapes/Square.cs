using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Rectangle
    {
        // constructors
        public Square() { }
        public Square(float side1) : base(side1, side1) { }
        
        // methods
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
