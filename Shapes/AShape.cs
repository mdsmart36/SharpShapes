using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;

namespace Shapes
{
    public abstract class AShape : IShape
    {
        

        public Color FillColor { get; protected set; }
        public Color BorderColor { get; protected set; }

        public AShape()
        {
            this.BorderColor = Color.AliceBlue;
            this.FillColor = Color.Bisque;
        }

        public virtual void DrawOnto(Canvas theCanvas, int x, int y) { throw new NotImplementedException(); }
        public virtual void Scale(int percent) { throw new NotImplementedException(); }
        public abstract float Area();
        public abstract float Perimeter();
    }
}