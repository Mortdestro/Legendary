using System;
using System.Collections.Generic;
using System.Text;
using static LegendaryEngine.Utilities;

namespace LegendaryEngine.Cards
{
    public class VictoryCard : Card
    {
        public virtual float PrintedVictoryPoints { get; set; }
        public virtual Func<VictoryCard, GameEngine, Player, float> VictoryPoints { get; set; } = DefaultVictoryPoints;

        public static float DefaultVictoryPoints(VictoryCard card, GameEngine game, Player player) => card.PrintedVictoryPoints;
    }
}
