using System;
using codekata.Codewars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codekata.tests.Codewars
{
    [TestClass]
    public class RecreationOneTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = RecreationOne.listSquared(5, 3);
            Assert.AreEqual("[]", RecreationOne.listSquared(5, 3));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("[[1, 1], [42, 2500], [246, 84100]]", RecreationOne.listSquared(1, 250));
            Assert.AreEqual("[[42, 2500], [246, 84100]]", RecreationOne.listSquared(42, 250));
            Assert.AreEqual("[[287, 84100]]", RecreationOne.listSquared(250, 500));
        }
    }
}
