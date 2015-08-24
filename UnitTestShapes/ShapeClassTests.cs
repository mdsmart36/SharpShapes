using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Drawing;

namespace UnitTestShapes
{
    [TestClass]
    public class ShapeClassTests
    {
        private class MyMockShape : AShape
        {
            public MyMockShape()
            {
                this.BorderColor = Color.AliceBlue;
                this.FillColor = Color.Bisque;
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
            Assert.AreEqual(Color.Bisque, myShape.FillColor);            
        }

        [TestMethod]
        public void TestAbstractShapeClassHasBorderColor()
        {
            Assert.AreNotEqual(Color.Aqua, myShape.BorderColor);
            Assert.AreEqual(Color.AliceBlue, myShape.BorderColor);
        }
    }
}
