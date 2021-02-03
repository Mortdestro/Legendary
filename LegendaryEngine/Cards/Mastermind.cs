using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class Mastermind : Card
    {
        // @TODO: Always leads
        // @TODO: Setup
        public override string Title { get; set; } = "Mastermind";

        public virtual Func<GameEngine, Player, bool> FightCondition { get; set; } = DefaultFightCondition;
        public virtual Action<GameEngine, Player> MasterStrike { get; set; } = DefaultMasterStrike;

        public static bool DefaultFightCondition(GameEngine game, Player player) => true;

        public static void DefaultMasterStrike(GameEngine game, Player player) { }
    }
}
