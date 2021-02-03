using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class MastermindTactic : IVictoryCard
    {
        public string ID { get; set; }
        public Action<MastermindTactic, GameEngine, Player> Fight { get; set; } = DefaultFight;
        public string FlavorText { get; set; }
        public float PrintedVictoryPoints { get; set; } = 5;
        public string RulesText { get; set; }
        public string Subtitle { get; set; } = "Tactic";
        public string Title { get; set; } = "Mastermind";
        public Func<IVictoryCard, GameEngine, Player, float> VictoryPoints { get; set; } = DefaultVictoryPoints;

        public static void DefaultFight(MastermindTactic card, GameEngine game, Player player) { }

        public static float DefaultVictoryPoints(IVictoryCard card, GameEngine game, Player player) => card.PrintedVictoryPoints;
    }
}
