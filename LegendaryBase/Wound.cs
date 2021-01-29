using System;
using LegendaryEngine;

namespace LegendaryHeroes
{
    public class Wound : IBadCard
    {
        public void Healing(Player player, GameState gameState)
        {
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

        public bool HealingCondition(Player player, GameState gameState)
        {
            if (player != gameState.CurrentTurn.Player) return false;
            throw new NotImplementedException();
        }
    }
}
