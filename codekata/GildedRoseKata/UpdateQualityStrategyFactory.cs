using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.GildedRoseKata
{
    public class UpdateQualityStrategyFactory
    {
        private static IDictionary<string, IUpdateQualityStrategy> updateStrategyMap;

        static UpdateQualityStrategyFactory()
        {
            updateStrategyMap = new Dictionary<string, IUpdateQualityStrategy>
            {
                {"Backstage passes to a TAFKAL80ETC concert", new BackStagePassUpdateQualityStrategy() },
                {"Aged Brie", new BetterWithTimeUpdateQualityStrategy() },
                {"Conjured Mana Cake", new ConjuredItemUpdateQualityStrategy() },
                {"Sulfuras, Hand of Ragnaros", new LegendaryUpdateQualityStrategy() },
                {"", new DefaultUpdateQualityStrategy() }
            };
        }

        public static IUpdateQualityStrategy GetUpdateQualityStrategy(Item item)
        {
            if(updateStrategyMap.ContainsKey(item.Name))
            {
                return updateStrategyMap[item.Name];
            }

            return updateStrategyMap[""];
        }

    }
}
