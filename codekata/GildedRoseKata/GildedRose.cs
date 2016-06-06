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

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                var storeItem = new StoreItem(item);
                storeItem.UpdateItemQuality();
            }
        }

    }
}