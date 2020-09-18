using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace UnitTests
{
    [TestClass]
    public class PointTests
    {
        private Point p1 = new Point(10, 20);
        private Point p2 = new Point(-20, 60);
        double dx = 0;
        double dy = 0;
        double angle = Math.PI / 3;

        [TestMethod]
        public void TestRho()
        {
            double expected = p1.Rho();
            double actual = Math.Sqrt(Math.Pow(10, 2) + Math.Pow(20, 2));
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTheta()
        {
            double expected = p1.Theta();
            double actual = Math.Atan2(20, 10);
            Assert.AreEqual(expected, actual);
        }
       
        [TestMethod]
        public void TestDistance()
        {
            double expected = p1.Distance(p2);
            double actual = p1.VectorTo(p2).Rho();
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestVectorTo()
        {
            Point expected = p1.VectorTo(p2);
            Point actual = new Point(-20 - 10, 60 - 20);
            Assert.AreEqual(expected.X, actual.X);
            Assert.AreEqual(expected.Y, actual.Y);
        }
        
        [TestMethod]
        public void TestTranslate()
        {
            p1.Translate(dx, dy);
            Point expected = new Point(10 + dx, 20 + dy);
            Assert.AreEqual(expected.X, p1.X);
            Assert.AreEqual(expected.Y, p1.Y);
        }
    
        [TestMethod]
        public void TestScale()
        {
            Point expected = new Point(10, 20);
            expected.Scale(2);
            Assert.AreEqual(expected.X,20);
            Assert.AreEqual(expected.Y, 40);
        }
       
        [TestMethod]
        public void TestCentreRotate() 
        {
            double expected = p1.Theta() + angle / (2 * Math.PI);
            double actual = Math.Atan2(20, 10) + angle / (2 * Math.PI);
            Assert.AreEqual(expected, actual);
        }
     
        [TestMethod]
        public void TestRotate() 
        {
            double x = p1.VectorTo(p1).Theta() % (2 * Math.PI);
            double y = p1.VectorTo(p1).Theta() + angle % (2 * Math.PI);
            double actual = y - x;
            Assert.AreEqual(angle, actual);
        }
    }
}
