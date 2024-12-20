using GildedRoseKata.Constants;
using GildedRoseKata.Contracts;

namespace GildedRoseKata.Strategies;

public class ItemStrategyFactory
{
    public static IItemStrategy Create(string name)
    {
        return name switch
        {
            ItemName.AgedBrie => new AgedStrategy([], false),
            ItemName.BackstagePasses => new AgedStrategy([6, 11], true),
            ItemName.Sulfuras => new LegendaryStrategy(),
            _ => new StandardStrategy(),
        };
    }
}
