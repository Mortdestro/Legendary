using System;
using LegendaryEngine;
using LegendaryEngine.Cards;
using LegendaryEngine.DefaultCards;

namespace LegendaryVillains
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
