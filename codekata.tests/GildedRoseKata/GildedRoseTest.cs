// <copyright file="GildedRoseTest.cs" company="Microsoft">Copyright (c) Microsoft. All rights reserved.</copyright>
using System;
using System.Collections.Generic;

namespace codekata.tests
{
    using System.IO;
    using System.Text;

    using ApprovalTests;
    using ApprovalTests.Reporters;

    using codekata.GildedRoseKata;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GildedRoseTest
    {
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