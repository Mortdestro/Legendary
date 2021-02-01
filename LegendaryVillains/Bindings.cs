using System;
using LegendaryEngine;
using LegendaryEngine.CardInterfaces;
using LegendaryEngine.DefaultCards;

namespace LegendaryVillains
{
    public class Bindings : DefaultBadCard
    {
        public override void Healing(GameEngine game, Player player)
        {
            throw new NotImplementedException();
        }

        public override bool HealingCondition(GameEngine game, Player player)
        {
            bool truth = base.HealingCondition(game, player);
            throw new NotImplementedException();
        }
    }
}
