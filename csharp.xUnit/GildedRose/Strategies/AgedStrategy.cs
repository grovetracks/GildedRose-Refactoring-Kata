using GildedRoseKata.Contracts;
using System;
using System.Linq;

namespace GildedRoseKata.Strategies;

public class AgedStrategy(int[] qualityMultiplierThresholds, bool isDepletedAfterSellIn) : IItemStrategy
{
    private readonly int[] _qualityMultiplierThresholds = qualityMultiplierThresholds;
    private readonly bool _isDepletedAfterSellIn = isDepletedAfterSellIn;

    public void Execute(Item item)
    {
        var qualityFactor = _qualityMultiplierThresholds.Count(q => item.SellIn < q);

        item.SellIn--;

        if (item.SellIn < 0 && _isDepletedAfterSellIn)
        {
            item.Quality = 0;
            return;
        }

        var sellInFactor = item.SellIn < 0 && item.Quality < 50 ? 1 : 0;


        item.Quality = Math.Min(50, item.Quality + (1 * (1 + qualityFactor + sellInFactor)));
    }
}
