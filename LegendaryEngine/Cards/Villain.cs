using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class Villain : IVictoryCard
    {
        public string ID { get; set; }
        public float PrintedVictoryPoints { get; set; }
        public string FlavorText { get; set; }
        public string RulesText { get; set; }
        public string Subtitle { get; set; }
        public string Title { get; set; } = "Villain";
        public Func<IVictoryCard, GameEngine, Player, float> VictoryPoints { get; set; } = DefaultVictoryPoints;

        public static float DefaultVictoryPoints(IVictoryCard card, GameEngine game, Player player) => card.PrintedVictoryPoints;
    }
}
