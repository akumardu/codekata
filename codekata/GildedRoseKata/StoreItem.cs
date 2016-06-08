using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.GildedRoseKata
{
    public class StoreItem
    {
        private readonly Item item;

        private const int MAXQUALITY = 50;

        private readonly IUpdateQualityStrategy updateQualityStrategy;

        public StoreItem()
        {
        }

        public StoreItem(Item item)
        {
            this.item = item;
            this.updateQualityStrategy = UpdateQualityStrategyFactory.GetUpdateQualityStrategy(item);
        }

        public string Name
        {
            get { return this.item.Name; }
            set { this.item.Name = value; }
        }

        public int Quality
        {
            get { return this.item.Quality; }
            set
            {
                // TODO: Methods for IncrementQuality and DecrementQuality
                if (value >= 0 && value <= MAXQUALITY)
                {
                    this.item.Quality = value;
                }
            }
        }

        public int SellIn
        {
            get { return this.item.SellIn; }
            set { this.item.SellIn = value; }
        }

        public void UpdateItemQuality()
        {
            this.updateQualityStrategy.UpdateQuality(this);
        }
    }
}
