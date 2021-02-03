using LegendaryEngine;
using LegendaryEngine.Cards;
using LegendaryEngine.DefaultCards;
using System;

namespace LegendaryTestExpansion
{
    public static class Bystanders
    {
        public static Bystander CreateBystanderX()
        {
            return new Bystander
            {
                ID = "BystanderX",
                PrintedVictoryPoints = 2
            };
        }
    }
}
