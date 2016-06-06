using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.GildedRoseKata
{
    public class ConjuredItemUpdateQualityStrategy : IUpdateQualityStrategy
    {
        public void UpdateQuality(StoreItem item)
        {
            item.Quality -= 2;
            if (item.SellIn <= 0)
            {
                item.Quality -= 2;
            }

            item.SellIn--;
        }
    }
}
