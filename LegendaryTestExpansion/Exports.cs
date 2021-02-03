using LegendaryEngine;
using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendaryTestExpansion
{
    public static class Exports
    {
        public static readonly Module Module = new Module
        {
            Name = "Test Expansion",
            BadCards = new Dictionary<string, List<BadCard>>
            {
                { "Wound", Enumerable.Repeat(BadCards.CreateBadCardX(), 10).ToList() }
            },
            Bystanders = Enumerable.Repeat(Bystanders.CreateBystanderX(), 4).ToList(),
            StandardHeroes = new Dictionary<string, List<Hero>>
            {
                { "Hero X", Enumerable.Repeat(Heroes.CreateHeroX(), 30).ToList() }
            }
        };
    }
}
