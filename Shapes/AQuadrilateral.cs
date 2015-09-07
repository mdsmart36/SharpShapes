using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows;
//using System.Drawing;

namespace Shapes
{
    public abstract class AQuadrilateral : AShape
    {
        public AQuadrilateral() : base() { }

        public AQuadrilateral(float side1, float side2, float side3, float side4) : base()
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
            this.Side4 = side4;
        }

        private float side1;
        private float side2;
        private float side3;
        private float side4;

        public float Side1
        {
            get { return side1; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    side1 = value;
                }
            }
        }
        public float Side2
        {
            get { return side2; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    side2 = value;
                }
            }
        }
        public float Side3
        {
            get { return side3; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    side3 = value;
                }
            }
        }
        public float Side4
        {
            get { return side4; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    side4 = value;
                }
            }
        }
            

        public abstract override float Area();
        public override float Perimeter()
        {
            if (Side1 == 0.0 || Side2 == 0.0 || Side3 == 0.0 || Side4 == 0.0)
            {
                throw new ArgumentException();
            }
            return Side1 + Side2 + Side3 + Side4;
        }

        public override void Scale(int percent)
        {
            if (percent == 0 || percent <= -100)
            {
                throw new ArgumentException();
            }
            
            this.Side1 = Side1 * (100 + percent) / 100;
            this.Side2 = Side2 * (100 + percent) / 100;
            this.Side3 = Side3 * (100 + percent) / 100;
            this.Side4 = Side4 * (100 + percent) / 100;

        }

        public Polygon CreatePolygon()
        {
            Polygon poly = new Polygon();
            poly.Fill = new SolidColorBrush(this.FillColor);
            poly.Stroke = new SolidColorBrush(this.BorderColor);
            poly.StrokeThickness = 2;
            return poly;
        }

        public override void DrawOnto(Canvas theCanvas, int x, int y)
        {
            Polygon myPolygon = CreatePolygon();
            Point p1 = new Point(x, y);
            Point p2 = new Point(x, y + this.Side2); // Or this.Right
            Point p3 = new Point(x + this.Side3, y + this.Side4);
            Point p4 = new Point(x + this.Side1, y);
            PointCollection myPoints = new PointCollection();
            myPoints.Add(p1);
            myPoints.Add(p2);
            myPoints.Add(p3);
            myPoints.Add(p4);
            myPolygon.Points = myPoints;

            theCanvas.Children.Add(myPolygon);
        }
    }
}
