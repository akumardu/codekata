using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codekata.tests.GildedRoseKata
{
    using codekata.GildedRoseKata;

    [TestClass]
    public class ConjuredItemUpdateQualityStrategyTest : BaseStrategyTest
    {
        private static StoreItem GetConjuredItem(int sellIn = DEFAULT_STARTING_SELLIN, int quality = DEFAULT_STARTING_QUALITY)
        {
            return new StoreItem(new Item { Name = "Conjured Mana Cake", SellIn = sellIn, Quality = quality });
        }

        private readonly IUpdateQualityStrategy iUpdateQualityStrategy = new ConjuredItemUpdateQualityStrategy();

        [TestMethod]
        public void ReduceConjuredItemQualityByTwo()
        {
            var conjuredItem = GetConjuredItem();
            int startingQuality = conjuredItem.Quality;
            this.iUpdateQualityStrategy.UpdateQuality(conjuredItem);

            Assert.AreEqual(startingQuality - 2, conjuredItem.Quality);
        }

        [TestMethod]
        public void ReduceConjureditemSellInByOne()
        {
            var conjuredItem = GetConjuredItem();
            int startingSellin = conjuredItem.SellIn;
            this.iUpdateQualityStrategy.UpdateQuality(conjuredItem);

            Assert.AreEqual(startingSellin - 1, conjuredItem.SellIn);
        }

        [TestMethod]
        public void ReduceNormalItemQualityByFourWhenSellinLessThan1()
        {
            var conjuredItem = GetConjuredItem(sellIn: 0);
            int startingQuality = conjuredItem.Quality;
            this.iUpdateQualityStrategy.UpdateQuality(conjuredItem);

            Assert.AreEqual(startingQuality - 4, conjuredItem.Quality);
        }

        [TestMethod]
        public void NotReduceQualityBelowZero()
        {
            var conjuredItem = GetConjuredItem(quality: 0);
            this.iUpdateQualityStrategy.UpdateQuality(conjuredItem);

            Assert.AreEqual(0, conjuredItem.Quality);
        }
    }
}
