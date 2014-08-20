using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareTest.Helpers;

namespace SoftwareTest.Tests
{
    [TestClass]
    public class PrimeFactorTester
    {
        [TestMethod]
        public void TestPrimeFactorOf24()
        {
            var factors = new List<int> { 2, 2, 2, 3 };
            var factorsOf24 = PrimeFactorHelper.GetFactors(24);

            CollectionAssert.AreEqual(factors, factorsOf24, "Factors are not equal");
        }

        [TestMethod]
        public void TestPrimeFactorOf45()
        {
            var factors = new List<int> { 3, 3, 5 };
            var factorsOf45 = PrimeFactorHelper.GetFactors(45);

            CollectionAssert.AreEqual(factors, factorsOf45, "Factors are not equal");
        }
    }
}
