using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class QuadrilateralTest
    {
        public class MockQuadrilateral : Quadrilateral
        {
            public MockQuadrilateral(float side1, float side2, float side3, float side4)
            {
                this.Side1 = side1;
                this.Side2 = side2;
                this.Side3 = side3;
                this.Side4 = side4;
            }

            public override float Area()
            {
                throw new NotImplementedException();
            }
        }

        [TestMethod]
        public void TestQuadrilateralComputePerimeter()
        {
            MockQuadrilateral myQuad = new MockQuadrilateral(2.3F, 3.1F, 1.9F, 3.9F);
            Assert.AreEqual(11.2F, myQuad.Perimeter());
        }

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
