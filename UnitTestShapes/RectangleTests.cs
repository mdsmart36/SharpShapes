using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Drawing;

namespace UnitTestShapes
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestRectangleConstructor()
        {
            // test that sides are set to 0 by default if a value is not specified
            Shapes.Rectangle rect = new Shapes.Rectangle();
            Assert.AreEqual(0, rect.Side1);
        }

        [TestMethod]
        public void TestRectangleConstructor2()
        {
            // test that side1 and side2 are set by constructor
            Shapes.Rectangle rect = new Shapes.Rectangle(5, 3);
            Assert.AreEqual(5, rect.Side1);
            Assert.AreEqual(3, rect.Side2);
        }

        [TestMethod]
        public void TestRectangleConstructor3()
        {
            // test that side1 and side2 are set by setter
            Shapes.Rectangle rect = new Shapes.Rectangle();
            rect.Side1 = 5;
            rect.Side2 = 3;
            Assert.AreEqual(5, rect.Side1);
            Assert.AreEqual(3, rect.Side2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleConstructorNegativeValue1()
        {
            Shapes.Rectangle rect = new Shapes.Rectangle(5, -3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleConstructorNegativeValue2()
        {
            Shapes.Rectangle rect = new Shapes.Rectangle(-5, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleSetterNegativeValue()
        {
            // test that you cannot set a side to be a negative or zero value
            Shapes.Rectangle rect = new Shapes.Rectangle();
            rect.Side1 = -2;
        }

        [TestMethod]
        public void TestRectangleComputeArea()
        {
            Shapes.Rectangle myRectangle = new Shapes.Rectangle(5, 10);
            Assert.AreEqual(50, myRectangle.Area());
        }

        [TestMethod]
        public void TestRectangleComputePerimeter()
        {
            Shapes.Rectangle myRectangle = new Shapes.Rectangle(5, 10);
            Assert.AreEqual(30, myRectangle.Perimeter());
        }

        [TestMethod]
        public void TestRectangleDefaultColors()
        {
            Shapes.Rectangle rect = new Shapes.Rectangle();
            Assert.AreEqual(Color.AliceBlue, rect.BorderColor);
            Assert.AreEqual(Color.Bisque, rect.FillColor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectanglePerimeterIsZero()
        {
            Shapes.Rectangle rect = new Shapes.Rectangle();
            rect.Perimeter();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleAreaIsZero()
        {
            Shapes.Rectangle rect = new Shapes.Rectangle();
            rect.Area();
        }
    }
}
