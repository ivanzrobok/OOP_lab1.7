using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_lab1._7;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        double area, perimetr;
        [TestMethod]
        public void TestMethod1()
        {
            PointsTriangle[] point1 = new PointsTriangle[]
            {
                new PointsTriangle{X = 0, Y = 4},
                new PointsTriangle{X = 0, Y = 0},
                new PointsTriangle{X= 3, Y = 0}
           };
            Triangle triangle = new Triangle();
            triangle.InIt(point1);

            area = triangle.Area();
            perimetr = triangle.Perimetr();
            Assert.AreEqual(12, perimetr);
        }
        //[TestMethod]
        //public void TestArea()
        //{
        //    Assert.AreEqual(12, perimetr);
        //}
        //[TestMethod]
        //public void TestPerimetr()
        //{
        //    Assert.AreEqual(6, area);
        //}
    }
}