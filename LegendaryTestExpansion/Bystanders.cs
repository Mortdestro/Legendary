using LegendaryEngine;
using LegendaryEngine.Cards;
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
