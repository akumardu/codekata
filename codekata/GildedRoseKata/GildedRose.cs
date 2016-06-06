using System.Collections.Generic;

namespace codekata.GildedRoseKata
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        private const int MAXQUALITY = 50;

        public void UpdateAgedBrie(Item agedBrie)
        {
            if(agedBrie.Quality < MAXQUALITY)
            {
                agedBrie.Quality += 1;
                if(agedBrie.SellIn <= 0 && agedBrie.Quality < MAXQUALITY)
                {
                    agedBrie.Quality += 1;
                }
            }

            agedBrie.SellIn -= 1;
        }

        public void UpdateBackstagePasses(Item backStagePass)
        {
            if(backStagePass.Quality < MAXQUALITY)
            {
                backStagePass.Quality += 1;
                if(backStagePass.SellIn < 11 && backStagePass.Quality < MAXQUALITY)
                {
                    backStagePass.Quality += 1;
                }
                if(backStagePass.SellIn < 6 && backStagePass.Quality < MAXQUALITY)
                {
                    backStagePass.Quality += 1;
                }
            }

            if (backStagePass.SellIn <= 0)
            {
                backStagePass.Quality = 0;
            }

            backStagePass.SellIn -= 1;
        }

        public void UpdateSulphuras(Item sulphuras)
        {
            
        }

        public void UpdateItem(Item item)
        {
            if(item.Quality > 0)
            {
                item.Quality -= 1;
                if (item.SellIn <= 0 && item.Quality > 0)
                {
                    item.Quality -= 1;
                }
            }

            item.SellIn -= 1;
        }

        public void UpdateConjuredItem(Item conjuredItem)
        {
            if(conjuredItem.Quality > 0)
            {
                conjuredItem.Quality -= 2;
                if(conjuredItem.SellIn <= 0 && conjuredItem.Quality > 0)
                {
                    conjuredItem.Quality -= 2;
                }
            }

            if(conjuredItem.Quality < 0)
            {
                conjuredItem.Quality = 0;
            }

            conjuredItem.SellIn -= 1;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == "Aged Brie")
                {
                    UpdateAgedBrie(Items[i]);
                }
                else if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    UpdateBackstagePasses(Items[i]);
                }
                else if(Items[i].Name == "Sulfuras, Hand of Ragnaros")
                {
                    UpdateSulphuras(Items[i]);
                }
                else if(Items[i].Name.StartsWith("Conjured"))
                {
                    UpdateConjuredItem(Items[i]);
                }
                else
                {
                    UpdateItem(Items[i]);
                }
            }
        }

    }

    public class Item
    {
        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }

}