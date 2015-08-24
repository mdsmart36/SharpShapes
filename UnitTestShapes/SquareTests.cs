using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void TestSquareComputeArea()
        {
            Square mySquare = new Square(10);
            Assert.AreEqual(100, mySquare.Area());
        }

        [TestMethod]
        public void TestSquareComputePerimeter()
        {
            Square mySquare = new Square(20);
            Assert.AreEqual(80, mySquare.Perimeter());
        }

    }
}
