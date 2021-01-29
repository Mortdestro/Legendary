using LegendaryEngine;
using System;

namespace LegendaryTestExpansion
{
    public class BadCardX : BadCard
    {
        public override void Healing(GameState gameState)
        {
            if (gameState.CurrentTurn.Player.Hand.Remove(this))
            {
                gameState.CurrentTurn.Player.DiscardPile.Add(this);
            }
        }

        public override bool HealingCondition(GameState gameState)
        {
            return true;
        }
    }
}
