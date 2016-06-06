using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.GildedRoseKata
{
    public class BackStagePassUpdateQualityStrategy : IUpdateQualityStrategy
    {
        public void UpdateQuality(StoreItem item)
        {
            item.Quality++;
            if (item.SellIn < 11)
            {
                item.Quality++;
            }
            if (item.SellIn < 6)
            {
                item.Quality++;
            }
            
            if (item.SellIn <= 0)
            {
                item.Quality = 0;
            }

            item.SellIn--;
        }
    }
}
