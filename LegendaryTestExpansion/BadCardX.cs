using LegendaryEngine;
using System;

namespace LegendaryTestExpansion
{
    public class BadCardX : IBadCard
    {
        public void Healing(Player player, GameState gameState)
        {
            if (player.Hand.Remove(this))
            {
                player.DiscardPile.Add(this);
            }
        }

        public bool HealingCondition(Player player, GameState gameState)
        {
            return player == gameState.CurrentTurn.Player;
        }
    }
}
