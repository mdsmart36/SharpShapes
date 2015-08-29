using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Drawing;

namespace UnitTestShapes
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void TestSquareConstructor()
        {
            // test that sides are set to 0 by default if a value is not specified
            Square square = new Square();
            Assert.AreEqual(0, square.Side1);
        }

        [TestMethod]
        public void TestSquareConstructor2()
        {
            // test that side1 is set by constructor
            Square square = new Square(5);
            Assert.AreEqual(5, square.Side1);
        }

        [TestMethod]
        public void TestSquareConstructor3()
        {
            // test that side2 is set by constructor
            Square square = new Square(5);
            Assert.AreEqual(5, square.Side2);
        }

        [TestMethod]
        public void TestSquareConstructor4()
        {
            // test that side3 and side4 remain in default state if not specifically set
            Square square = new Square(5);
            Assert.AreEqual(0, square.Side3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructor5()
        {
            // test that you cannot set a side to be a negative or zero value
            Square square = new Square(-2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructor6()
        {
            // test that you cannot set a side to be a negative or zero value
            Square square = new Square();
            square.Side1 = -2;
        }

        [TestMethod]
        public void TestSquareComputeArea()
        {
            Square mySquare = new Square(10);
            Assert.AreEqual(100, mySquare.Area());
        }

        [TestMethod]
        public void TestSquareComputeArea2()
        {
            Square mySquare = new Square(10);
            mySquare.Side1 = 5;
            Assert.AreEqual(25, mySquare.Area());
        }

        [TestMethod]
        public void TestSquareComputePerimeter()
        {
            Square mySquare = new Square(20);
            Assert.AreEqual(80, mySquare.Perimeter());
        }

        [TestMethod]
        public void TestSquareComputePerimeter2()
        {
            Square mySquare = new Square(10);
            mySquare.Side1 = 5;
            Assert.AreEqual(20, mySquare.Perimeter());
        }

        [TestMethod]
        public void TestSquareDefaultColors()
        {
            Square square = new Square();
            Assert.AreEqual(Color.AliceBlue, square.BorderColor);
            Assert.AreEqual(Color.Bisque, square.FillColor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareAreaIsZero()
        {
            Square square = new Square();
            square.Area();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquarePerimeterIsZero()
        {
            Square square = new Square();
            square.Perimeter();
        }
    }
}
