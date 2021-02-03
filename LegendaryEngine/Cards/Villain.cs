using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class Villain : VictoryCard
    {
        public override string Title { get; set; } = "Villain";

        public virtual Action<Villain, GameEngine, Player> Fight { get; set; } = DefaultFight;

        public static void DefaultFight(Villain card, GameEngine game, Player player) { }
    }
}
