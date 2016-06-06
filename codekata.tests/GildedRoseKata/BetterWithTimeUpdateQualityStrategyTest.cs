using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codekata.tests.GildedRoseKata
{
    using codekata.GildedRoseKata;

    [TestClass]
    public class BetterWithTimeUpdateQualityStrategyTest : BaseStrategyTest
    {
        private static StoreItem GetAgedBrie(int sellIn = DEFAULT_STARTING_SELLIN, int quality = DEFAULT_STARTING_QUALITY)
        {
            return new StoreItem(new Item { Name = "Aged Brie", SellIn = sellIn, Quality = quality });
        }

        private readonly IUpdateQualityStrategy iUpdateQualityStrategy = new BetterWithTimeUpdateQualityStrategy();

        [TestMethod]
        public void IncreaseQualityOfAgedBrie()
        {
            var agedBrie = GetAgedBrie();
            int startingQuality = agedBrie.Quality;
            this.iUpdateQualityStrategy.UpdateQuality(agedBrie);
            Assert.AreEqual(startingQuality + 1, agedBrie.Quality);
        }

        [TestMethod]
        public void IncreaseQualityOfAgedBrieByTwoAfterSellIn()
        {
            var agedBrie = GetAgedBrie(sellIn: 0);
            int startingQuality = agedBrie.Quality;
            this.iUpdateQualityStrategy.UpdateQuality(agedBrie);

            Assert.AreEqual(startingQuality + 2, agedBrie.Quality);
        }

        [TestMethod]
        public void NotIncreaseQualityOfAgedBriePastMaxQuality()
        {
            var agedBrie = GetAgedBrie(quality: MAXQUALITY);
            int startingQuality = agedBrie.Quality;
            this.iUpdateQualityStrategy.UpdateQuality(agedBrie);

            Assert.AreEqual(startingQuality, agedBrie.Quality);
        }
    }
}
