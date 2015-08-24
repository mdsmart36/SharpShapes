using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestRectangleComputeArea()
        {
            Rectangle myRectangle = new Rectangle(5, 10);
            Assert.AreEqual(50, myRectangle.Area());
        }

        [TestMethod]
        public void TestRectangleComputePerimeter()
        {
            Rectangle myRectangle = new Rectangle(5, 10);
            Assert.AreEqual(30, myRectangle.Perimeter());
        }
    }
}
