using GildedRoseKata.Contracts;
using System;

namespace GildedRoseKata.Strategies;

public class StandardStrategy : IItemStrategy
{
    public void Execute(Item item)
    {
        item.SellIn--;

        var qualityFactor = item.SellIn < 0 ? 2 : 1;
        item.Quality = Math.Max(0, item.Quality - (1 * qualityFactor));
    }
}
