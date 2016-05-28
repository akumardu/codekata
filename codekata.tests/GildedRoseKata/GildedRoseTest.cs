using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using codekata.GildedRoseKata;
using System.Text;
using System.IO;
using ApprovalTests;
using ApprovalTests.Reporters;

namespace codekata.tests
{
    [TestClass]
    public class GildedRoseTest
    {
        [TestMethod]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("foo", Items[0].Name);
        }

        [UseReporter(typeof(DiffReporter))]
        [TestMethod]
        public void ThirtyDays()
        {
            StringBuilder fakeoutput = new StringBuilder();
            Console.SetOut(new StringWriter(fakeoutput));
            Console.SetIn(new StringReader("a\n"));

            TestTextFixture.TestGildedRose();
            String output = fakeoutput.ToString();
            Approvals.Verify(output);
        }
    }
}
