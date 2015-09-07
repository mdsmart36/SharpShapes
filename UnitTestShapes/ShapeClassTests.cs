using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
//using System.Drawing;
using System.Windows.Media;

namespace UnitTestShapes
{
    [TestClass]
    public class ShapeClassTests
    {
        private class MyMockShape : AShape
        {
            public MyMockShape()
            {
                this.BorderColor = Colors.AliceBlue;
                this.FillColor = Colors.Bisque;
            }

            public override float Area()
            {
                throw new NotImplementedException();
            }

            public override float Perimeter()
            {
                throw new NotImplementedException();
            }
        }

        MyMockShape myShape = new MyMockShape();

        [TestMethod]
        public void TestAbstractShapeClassHasFillColor()
        {
            Assert.AreEqual(Colors.Bisque, myShape.FillColor);            
        }

        [TestMethod]
        public void TestAbstractShapeClassHasBorderColor()
        {
            Assert.AreNotEqual(Colors.Aqua, myShape.BorderColor);
            Assert.AreEqual(Colors.AliceBlue, myShape.BorderColor);
        }
    }
}
