using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class Scheme : Card
    {
        public override string Title { get; set; } = "Scheme";

        public virtual Func<GameEngine, bool> EvilWinCondition { get; set; }
        public virtual Action<GameEngine> Setup { get; set; }
        public virtual Action<GameEngine, Player> Twist { get; set; } = DefaultTwist;
        public virtual int Twists { get; set; }

        public static void DefaultTwist(GameEngine game, Player player)
        {
            game.Twist();
        }
    }
}
