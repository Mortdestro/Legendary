using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.CardInterfaces
{
    public class BadCard : ICard
    {
        public string ID { get; set; }
        public string FlavorText { get; set; }
        public Action<BadCard, GameEngine, Player> Healing { get; set; }
        public Func<BadCard, GameEngine, Player, bool> HealingCondition { get; set; } = DefaultHealingCondition;
        public string RulesText { get; set; }
        public string Subtitle { get; set; }
        public string Title { get; set; } = "Bad Card";

        public static bool DefaultHealingCondition(BadCard card, GameEngine game, Player player) => player == game.CurrentTurn.Player;
    }
}
