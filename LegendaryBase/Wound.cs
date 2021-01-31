using System;
using LegendaryEngine;
using LegendaryEngine.CardInterfaces;
using LegendaryEngine.DefaultCards;

namespace LegendaryHeroes
{
    public class Wound : DefaultBadCard
    {
        public override void Healing(Player player, GameState gameState)
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

        public override bool HealingCondition(Player player, GameState gameState)
        {
            if (player != gameState.CurrentTurn.Player) return false;
            throw new NotImplementedException();
        }
    }
}
