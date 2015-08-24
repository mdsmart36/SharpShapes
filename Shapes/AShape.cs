using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public abstract class AShape : IShape
    {
        
        public Color FillColor { get; protected set; }
        public Color BorderColor { get; protected set; }

        public abstract float Area();
        public abstract float Perimeter();
    }
}