using System;
using LegendaryEngine;
using LegendaryEngine.Cards;
using LegendaryEngine.DefaultCards;

namespace LegendaryVillains
{
    public static class BadCards
    {
        public static BadCard CreateBindings()
        {
            return new BadCard
            {
                ID = "Bindings",
                Healing = BindingsHealing,
                HealingCondition = BindingsHealingCondition,
                RulesText = "<b>Healing:</b> ", // @TODO
                Title = "Bindings"
            };
        }

        private static void BindingsHealing(BadCard card, GameEngine game, Player player)
        {
            throw new NotImplementedException();
        }

        private static bool BindingsHealingCondition(BadCard card, GameEngine game, Player player)
        {
            bool truth = BadCard.DefaultHealingCondition(card, game, player);
            throw new NotImplementedException();
        }
    }
}
