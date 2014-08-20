using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        [TestMethod]
        public void TestNumberOfLinesInFile()
        {
            var lines = File.ReadAllLines(@"Files\intFile.txt");
            Assert.AreEqual(6, lines.Count(), "Lines are not equal");
        }

        [TestMethod]
        public void TestNumberOfIntegersInFile()
        {
            var lines = File.ReadAllLines(@"Files\intFile.txt");
            var intCount = 0;
            foreach (var line in lines)
            {
                int number;
                if (int.TryParse(line, out number))
                {
                    intCount++;
                }
            }

            Assert.AreEqual(5, intCount, "Number of integers are not equal");
        }
    }
}
