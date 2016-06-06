using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.GildedRoseKata
{
    public interface IUpdateQualityStrategy
    {
        void UpdateQuality(StoreItem item);
    }
}
