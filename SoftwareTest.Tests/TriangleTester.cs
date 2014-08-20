using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareTest.Helpers;

namespace SoftwareTest.Tests
{
    [TestClass]
    public class TriangleTester
    {
        [TestMethod]
        public void TestIfTriangleIsEquilateral()
        {
            Assert.AreEqual(TriangleType.Equilateral, TriangleHelper.GetTriangleType(45, 45, 45),
                "Triangle is not Equilateral");
        }

        [TestMethod]
        public void TestIfTriangleIsIsosceles()
        {
            Assert.AreEqual(TriangleType.Isosceles, TriangleHelper.GetTriangleType(45, 45, 48),
                "Triangle is not Isosceles");
        }

        [TestMethod]
        public void TestIfTriangleIsScalene()
        {
            Assert.AreEqual(TriangleType.Scalene, TriangleHelper.GetTriangleType(46, 43, 48),
                "Triangle is not Scalene");
        }

        [TestMethod]
        public void TestIfTriangleIsNotValid()
        {
            Assert.AreEqual(TriangleType.Invalid, TriangleHelper.GetTriangleType(45, 48, 1),
                "Triangle is not valid");
        }
    }
}
