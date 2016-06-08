using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace codekata.tests.GildedRoseKata
{
    using codekata.GildedRoseKata;

    [TestClass]
    public class DefaultUpdateQualityStrategyTest : BaseStrategyTest
    {
        private static StoreItem GetNormalItem(int sellIn = DEFAULT_STARTING_SELLIN, int quality = DEFAULT_STARTING_QUALITY)
        {
            return new StoreItem(new Item { Name = "Dexterity Vest", SellIn = sellIn, Quality = quality });
        }

        private readonly IUpdateQualityStrategy iUpdateQualityStrategy = new DefaultUpdateQualityStrategy();

        [TestMethod]
        public void NotReduceQualityBelowZero()
        {
            // Arrange
            var normalItem = GetNormalItem(quality: 0);

            // Act
            this.iUpdateQualityStrategy.UpdateQuality(normalItem);

            // Assert
            Assert.AreEqual(0, normalItem.Quality);
        }

        [TestMethod]
        public void ReduceNormalItemQualityByOne()
        {
            var normalItem = GetNormalItem();
            int startingQuality = normalItem.Quality;
            this.iUpdateQualityStrategy.UpdateQuality(normalItem);

            Assert.AreEqual(startingQuality - 1, normalItem.Quality);
        }

        [TestMethod]
        public void ReduceNormalItemQualityByTwoWhenSellinLessThan1()
        {
            var normalItem = GetNormalItem(sellIn: 0);
            int startingQuality = normalItem.Quality;
            this.iUpdateQualityStrategy.UpdateQuality(normalItem);

            Assert.AreEqual(startingQuality - 2, normalItem.Quality);
        }

        [TestMethod]
        public void ReduceNormalitemsellInByOne()
        {
            var normalItem = GetNormalItem();
            int startingSellin = normalItem.SellIn;
            this.iUpdateQualityStrategy.UpdateQuality(normalItem); ;

            Assert.AreEqual(startingSellin - 1, normalItem.SellIn);
        }
    }
}
