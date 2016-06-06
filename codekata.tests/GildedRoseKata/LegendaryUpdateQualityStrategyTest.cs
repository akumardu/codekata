using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codekata.tests.GildedRoseKata
{
    using codekata.GildedRoseKata;

    [TestClass]
    public class LegendaryUpdateQualityStrategyTest : BaseStrategyTest
    {
        private static StoreItem GetSulfuras()
        {
            return new StoreItem(new Item() { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 });
        }

        private readonly IUpdateQualityStrategy iUpdateQualityStrategy = new LegendaryUpdateQualityStrategy();

        [TestMethod]
        public void NotChangeQualityOfSulfuras()
        {
            var sulfuras = GetSulfuras();
            int startingQuality = sulfuras.Quality;
            this.iUpdateQualityStrategy.UpdateQuality(sulfuras);

            Assert.AreEqual(startingQuality, sulfuras.Quality);
        }

        [TestMethod]
        public void NotChangeSellInOfSulfuras()
        {
            var sulfuras = GetSulfuras();
            int startingSellIn = sulfuras.SellIn;
            this.iUpdateQualityStrategy.UpdateQuality(sulfuras);

            Assert.AreEqual(startingSellIn, sulfuras.SellIn);
        }
    }
}
