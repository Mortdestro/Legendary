using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class BadCard : Card
    {
        public override string Title { get; set; } = "Bad Card"; 

        public virtual Action<BadCard, GameEngine, Player> Healing { get; set; }
        public virtual Func<BadCard, GameEngine, Player, bool> HealingCondition { get; set; } = DefaultHealingCondition;

        public static bool DefaultHealingCondition(BadCard card, GameEngine game, Player player) => player == game.CurrentTurn.Player;
    }
}
