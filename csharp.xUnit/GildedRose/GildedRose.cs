using GildedRoseKata.Strategies;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    readonly IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            ItemStrategyFactory.Create(Items[i].Name).Execute(Items[i]);

            #region Original
            //if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //{
            //    if (Items[i].Quality > 0)
            //    {
            //        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //        {
            //            // standard
            //            Items[i].Quality = Items[i].Quality - 1;
            //        }
            //    }
            //}
            //else
            //{
            //    if (Items[i].Quality < 50)
            //    {
            //        Items[i].Quality = Items[i].Quality + 1;

            //        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            //        {
            //            if (Items[i].SellIn < 11)
            //            {
            //                if (Items[i].Quality < 50)
            //                {
            //                    Items[i].Quality = Items[i].Quality + 1;
            //                }
            //            }

            //            if (Items[i].SellIn < 6)
            //            {
            //                if (Items[i].Quality < 50)
            //                {
            //                    Items[i].Quality = Items[i].Quality + 1;
            //                }
            //            }
            //        }
            //    }
            //}

            //if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //{
            //    // standard or aged
            //    Items[i].SellIn = Items[i].SellIn - 1;
            //}

            //if (Items[i].SellIn < 0)
            //{
            //    if (Items[i].Name != "Aged Brie")
            //    {
            //        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //        {
            //            if (Items[i].Quality > 0)
            //            {
            //                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //                {
            //                    // standard done
            //                    Items[i].Quality = Items[i].Quality - 1;
            //                }
            //            }
            //        }
            //        else
            //        {
            //            // standard done
            //            Items[i].Quality = Items[i].Quality - Items[i].Quality;
            //        }
            //    }
            //    else
            //    {
            //        if (Items[i].Quality < 50)
            //        {
            //            Items[i].Quality = Items[i].Quality + 1;
            //        }
            //    }
            //} 
            #endregion
        }
    }
}