using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class QuadrilateralClassTests
    {
        public class MockQuadrilateral : AQuadrilateral
        {
            public MockQuadrilateral()
            {

            }

            public MockQuadrilateral(float side1, float side2, float side3, float side4) : base(side1, side2, side3, side4)
            {
                
            }

            public override float Area()
            {
                throw new NotImplementedException();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuadHasDefaultSize()
        {
            MockQuadrilateral myQuad = new MockQuadrilateral();
            myQuad.Perimeter();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestQuadAreaNotImplemented()
        {
            MockQuadrilateral myQuad = new MockQuadrilateral();
            myQuad.Area();
        }

        [TestMethod]
        public void TestQuadrilateralComputePerimeter()
        {
            MockQuadrilateral myQuad = new MockQuadrilateral(2.3F, 3.1F, 1.9F, 3.9F);
            Assert.AreEqual(11.2F, myQuad.Perimeter());
        }

        [TestMethod]
        public void TestQuadCanComputePerimeter2()
        {
            MockQuadrilateral myQuad = new MockQuadrilateral();
            myQuad.Side1 = 2;
            myQuad.Side2 = 2;
            myQuad.Side3 = 2;
            myQuad.Side4 = 2;
            Assert.AreEqual(8, myQuad.Perimeter());
        }

        [TestMethod]
        public void TestQuadPerimetersAreTheSame()
        {
            MockQuadrilateral quad1 = new MockQuadrilateral();
            quad1.Side1 = 2;
            quad1.Side2 = 2;
            quad1.Side3 = 2;
            quad1.Side4 = 2;
            MockQuadrilateral quad2 = new MockQuadrilateral(2, 2, 2, 2);
            Assert.AreEqual(quad1.Perimeter(), quad2.Perimeter());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuadNoNegativeSides()
        {
            MockQuadrilateral quad1 = new MockQuadrilateral();
            quad1.Side1 = 2;
            quad1.Side2 = 2;
            quad1.Side3 = 2;
            quad1.Side4 = -2;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuadNoNegativeSidesInConstructor()
        {
            MockQuadrilateral quad = new MockQuadrilateral(2, -2, 2, 2);
        }
        
    }
}
