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
            public override float Area()
            {
                throw new NotImplementedException();
            }
        }

        [TestMethod]
        public void TestQuadrilateralComputePerimeter()
        {
            MockQuadrilateral myQuad = new MockQuadrilateral();
            myQuad.side1 = 2.3F;
            myQuad.side2 = 3.1F;
            myQuad.side3 = 1.9F;
            myQuad.side4 = 3.9F;
            
            Assert.AreEqual(11.2F, myQuad.Perimeter());
        }

        [TestMethod]
        public void TestSquareComputeArea()
        {
            Square mySquare = new Square();
            mySquare.side1 = 10;
            Assert.AreEqual(100, mySquare.Area());
        }

        [TestMethod]
        public void TestSquareComputePerimeter()
        {
            Square mySquare = new Square();
            mySquare.side1 = 20;
            Assert.AreEqual(80, mySquare.Perimeter());
        }

        [TestMethod]
        public void TestRectangleComputeArea()
        {
            Rectangle myRectangle = new Rectangle();
            myRectangle.side1 = 5;
            myRectangle.side2 = 10;
            Assert.AreEqual(50, myRectangle.Area());
        }

        [TestMethod]
        public void TestRectangleComputePerimeter()
        {
            Rectangle myRectangle = new Rectangle();
            myRectangle.side1 = 5;
            myRectangle.side2 = 10;
            Assert.AreEqual(30, myRectangle.Perimeter());
        }
    }
}
