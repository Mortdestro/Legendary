using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class Villain : VictoryCard
    {
        public override string Title { get; set; } = "Villain";

        public virtual Action<Villain, GameEngine, Player> Ambush { get; set; } = DefaultAmbush;
        public virtual Action<Villain, GameEngine, Player> Escape { get; set; } = DefaultEscape;
        public virtual Action<Villain, GameEngine, Player> Fight { get; set; } = DefaultFight;

        public static void DefaultAmbush(Villain card, GameEngine game, Player player) { }
        public static void DefaultEscape(Villain card, GameEngine game, Player player) { }
        public static void DefaultFight(Villain card, GameEngine game, Player player) { }
    }
}
