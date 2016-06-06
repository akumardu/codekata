using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.GildedRoseKata
{
    public class DefaultUpdateQualityStrategy: IUpdateQualityStrategy
    {
        public void UpdateQuality(StoreItem item)
        {
            item.Quality--;
            if (item.SellIn <= 0)
            {
                item.Quality--;
            }
            
            item.SellIn--;
        }
    }
}
