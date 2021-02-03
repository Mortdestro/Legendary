using System;
using LegendaryEngine;
using LegendaryEngine.Cards;
using LegendaryEngine.DefaultCards;

namespace LegendaryHeroes
{
    public static class Bystanders
    {
        public static Bystander CreateBystander()
        {
            return new Bystander
            {
                ID = "Bystander"
            };
        }
    }
}
