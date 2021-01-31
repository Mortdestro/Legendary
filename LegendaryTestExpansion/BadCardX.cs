using LegendaryEngine;
using LegendaryEngine.CardInterfaces;
using LegendaryEngine.DefaultCards;
using System;

namespace LegendaryTestExpansion
{
    public class BadCardX : DefaultBadCard
    {
        public override string Title => "Bad X";

        public override void Healing(Player player, GameState gameState)
        {
            if (player.Hand.Remove(this))
            {
                player.DiscardPile.Add(this);
            }
        }
    }
}
