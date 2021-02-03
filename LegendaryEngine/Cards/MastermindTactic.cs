using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class MastermindTactic : VictoryCard
    {
        public override float PrintedVictoryPoints { get; set; } = 5;
        public override string Subtitle { get; set; } = "Tactic";
        public override string Title { get; set; } = "Mastermind";

        public virtual Action<MastermindTactic, GameEngine, Player> Fight { get; set; } = DefaultFight;

        public static void DefaultFight(MastermindTactic card, GameEngine game, Player player) { }
    }
}
