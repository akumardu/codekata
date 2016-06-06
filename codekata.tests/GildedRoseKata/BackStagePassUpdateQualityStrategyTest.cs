using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codekata.tests.GildedRoseKata
{
    using codekata.GildedRoseKata;

    [TestClass]
    public class BackStagePassUpdateQualityStrategyTest : BaseStrategyTest
    {

        private static StoreItem GetBackStagePasses(int sellIn = DEFAULT_STARTING_SELLIN, int quality = DEFAULT_STARTING_QUALITY)
        {
            return new StoreItem(new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = quality });
        }

        private readonly IUpdateQualityStrategy iUpdateQualityStrategy = new BackStagePassUpdateQualityStrategy();

        [TestMethod]
        public void IncreaseQualityOfBackstagePassesByOneWith11DaysLeft()
        {
            var backStagePasses = GetBackStagePasses(sellIn: 11);
            int startingQuality = backStagePasses.Quality;

            this.iUpdateQualityStrategy.UpdateQuality(backStagePasses);

            Assert.AreEqual(startingQuality + 1, backStagePasses.Quality);
        }

        [TestMethod]
        public void IncreaseQualityOfBackstagePassesByTwoWith10DaysLeft()
        {
            var backStagePasses = GetBackStagePasses(sellIn: 10);
            
            int startingQuality = backStagePasses.Quality;
            this.iUpdateQualityStrategy.UpdateQuality(backStagePasses);

            Assert.AreEqual(startingQuality + 2, backStagePasses.Quality);
        }

        [TestMethod]
        public void IncreaseQualityOfBackstagePassesByTwoWith6DaysLeft()
        {
            var backStagePasses = GetBackStagePasses(sellIn: 6);
            
            int startingQuality = backStagePasses.Quality;
            this.iUpdateQualityStrategy.UpdateQuality(backStagePasses);

            Assert.AreEqual(startingQuality + 2, backStagePasses.Quality);
        }

        [TestMethod]
        public void IncreaseQualityOfBackstagePassesByThreeWith5DaysLeft()
        {
            var backStagePasses = GetBackStagePasses(sellIn: 5);
            
            int startingQuality = backStagePasses.Quality;
            this.iUpdateQualityStrategy.UpdateQuality(backStagePasses);

            Assert.AreEqual(startingQuality + 3, backStagePasses.Quality);
        }

        [TestMethod]
        public void IncreaseQualityOfBackstagePassesByThreeWith1DayLeft()
        {
            var backStagePasses = GetBackStagePasses(sellIn: 1);
            int startingQuality = backStagePasses.Quality;
            this.iUpdateQualityStrategy.UpdateQuality(backStagePasses);

            Assert.AreEqual(startingQuality + 3, backStagePasses.Quality);
        }

        [TestMethod]
        public void DecreaseQualityOfBackstagePassesToZeroWhenSellInPasses()
        {
            var backStagePasses = GetBackStagePasses(sellIn: 0);
            this.iUpdateQualityStrategy.UpdateQuality(backStagePasses);

            Assert.AreEqual(0, backStagePasses.Quality);
        }
    }
}
