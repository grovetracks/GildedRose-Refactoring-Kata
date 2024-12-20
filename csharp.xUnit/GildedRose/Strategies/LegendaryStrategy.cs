using GildedRoseKata.Contracts;
using System;

namespace GildedRoseKata.Strategies;

internal class LegendaryStrategy : IItemStrategy
{
    public void Execute(Item item)
    {
        if (item.SellIn < 0 && item.Quality < 50)
        {
            item.Quality++;
        }
    }
}
