using System;
using LegendaryEngine;

namespace LegendaryHeroes
{
    public class Wound : BadCard
    {
        public override void Healing(GameState gameState)
        {
            Player player = gameState.CurrentTurn.Player;
            foreach (ICard card in player.Hand)
            {
                if (card is Wound)
                {
                    if (player.Hand.Remove(card))
                    {
                        gameState.KOPile.Add(card);
                    }
                }
            }
        }

        public override bool HealingCondition(GameState gameState)
        {
            throw new NotImplementedException();
        }
    }
}
