using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class Mastermind : ICard
    {
        // @TODO: Always leads
        // @TODO: Setup
        public string ID { get; set; }
        public Func<GameEngine, Player, bool> FightCondition { get; set; } = DefaultFightCondition;
        public string FlavorText { get; set; }
        public Action<GameEngine, Player> MasterStrike { get; set; } = DefaultMasterStrike;
        public string RulesText { get; set; }
        public string Subtitle { get; set; }
        public string Title { get; set; } = "Mastermind";

        public static bool DefaultFightCondition(GameEngine game, Player player) => true;

        public static void DefaultMasterStrike(GameEngine game, Player player) { }
    }
}
