using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Drawing;

namespace UnitTestShapes
{
    [TestClass]
    public class AbstractClassTest
    {
        private class MyMockShape : Shape
        {
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
            myShape.FillColor = Color.Azure;
            Assert.AreEqual(Color.Azure, myShape.FillColor);
            
        }

        [TestMethod]
        public void TestAbstractShapeClassHasBorderColor()
        {
            myShape.BorderColor = Color.BlanchedAlmond;
            Assert.AreNotEqual(Color.AliceBlue, myShape.BorderColor);
            Assert.AreEqual(Color.BlanchedAlmond, myShape.BorderColor);
        }
    }
}
