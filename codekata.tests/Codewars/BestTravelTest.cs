
namespace codekata.tests.Codewars
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using codekata.Codewars;

    /// <summary>
    /// Summary description for BestTravelTest
    /// </summary>
    [TestClass]
    public class BestTravelTest
    {
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            List<int> ts = new List<int> { 50, 55, 56, 57, 58 };
            int? n = BestTravel.chooseBestSum(163, 3, ts);
            Assert.AreEqual(163, n);

            ts = new List<int> { 50 };
            n = BestTravel.chooseBestSum(163, 3, ts);
            Assert.AreEqual(null, n);

            ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
            n = BestTravel.chooseBestSum(230, 3, ts);
            Assert.AreEqual(228, n);
            n = BestTravel.chooseBestSum(331, 2, ts);
            Assert.AreEqual(178, n);
            n = BestTravel.chooseBestSum(331, 4, ts);
            Assert.AreEqual(331, n);
            n = BestTravel.chooseBestSum(331, 5, ts);
            Assert.AreEqual(null, n);
            n = BestTravel.chooseBestSum(331, 1, ts);
            Assert.AreEqual(91, n);
            n = BestTravel.chooseBestSum(700, 8, ts);
            Assert.AreEqual(null, n);
        }

        [TestMethod]
        public void Test2()
        {
            Console.WriteLine("****** Basic Tests bigger numbers");
            List<int> ts = new List<int> { 100, 76, 56, 44, 89, 73, 68, 56, 64, 123, 2333, 144, 50, 132, 123, 34, 89 };
            int? n = BestTravel.chooseBestSum(230, 4, ts);
            Assert.AreEqual(230, n);
            n = BestTravel.chooseBestSum(430, 5, ts);
            Assert.AreEqual(430, n);
            n = BestTravel.chooseBestSum(430, 8, ts);
            Assert.AreEqual(null, n);
            n = BestTravel.chooseBestSum(880, 8, ts);
            Assert.AreEqual(876, n);
            n = BestTravel.chooseBestSum(2430, 15, ts);
            Assert.AreEqual(1287, n);
            n = BestTravel.chooseBestSum(100, 2, ts);
            Assert.AreEqual(100, n);
            n = BestTravel.chooseBestSum(276, 3, ts);
            Assert.AreEqual(276, n);
            n = BestTravel.chooseBestSum(3760, 17, ts);
            Assert.AreEqual(3654, n);
            n = BestTravel.chooseBestSum(3760, 40, ts);
            Assert.AreEqual(null, n);
            n = BestTravel.chooseBestSum(50, 1, ts);
            Assert.AreEqual(50, n);
            n = BestTravel.chooseBestSum(1000, 18, ts);
            Assert.AreEqual(null, n);

            ts = new List<int> { 100, 64, 123, 2333, 144, 50, 132, 123, 34, 89 };
            n = BestTravel.chooseBestSum(230, 4, ts);
            Assert.AreEqual(null, n);
            n = BestTravel.chooseBestSum(230, 2, ts);
            Assert.AreEqual(223, n);
            n = BestTravel.chooseBestSum(2333, 1, ts);
            Assert.AreEqual(2333, n);
            n = BestTravel.chooseBestSum(2333, 8, ts);
            Assert.AreEqual(825, n);

            ts = new List<int> { 1000, 640, 1230, 2333, 1440, 500, 1320, 1230, 340, 890, 732, 1346 };
            n = BestTravel.chooseBestSum(2300, 4, ts);
            Assert.AreEqual(2212, n);
            n = BestTravel.chooseBestSum(2300, 5, ts);
            Assert.AreEqual(null, n);
            n = BestTravel.chooseBestSum(2332, 3, ts);
            Assert.AreEqual(2326, n);
            n = BestTravel.chooseBestSum(23331, 8, ts);
            Assert.AreEqual(10789, n);
            n = BestTravel.chooseBestSum(331, 2, ts);
            Assert.AreEqual(null, n);
        }
    }
}
