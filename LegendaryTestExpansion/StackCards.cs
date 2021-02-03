using LegendaryEngine;
using LegendaryEngine.Cards;
using LegendaryEngine.DefaultCards;
using System;

namespace LegendaryTestExpansion
{
    public static class StackCards
    {
        public static BadCard CreateBadCardX()
        {
            return new BadCard
            {
                ID = "BadCardX",
                Healing = XHealing,
                RulesText = "<b>Healing:</b> On your turn, you may put this Wound in your discard pile.", // @TODO
                Title = "Bad X"
            };
        }

        public static Bystander CreateBystanderX()
        {
            return new Bystander
            {
                ID = "BystanderX",
                PrintedVictoryPoints = 2
            };
        }

        private static void XHealing(BadCard card, GameEngine game, Player player)
        {
            if (player.Hand.Remove(card))
            {
                player.DiscardPile.Add(card);
            }
        }
    }
}
