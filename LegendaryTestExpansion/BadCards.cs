using LegendaryEngine;
using LegendaryEngine.Cards;
using System;

namespace LegendaryTestExpansion
{
    public static class BadCards
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

        private static void XHealing(BadCard card, GameEngine game, Player player)
        {
            if (player.Hand.Remove(card))
            {
                player.DiscardPile.Add(card);
            }
        }
    }
}
