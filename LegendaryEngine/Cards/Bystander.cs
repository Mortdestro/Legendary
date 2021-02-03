using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class Bystander : IVictoryCard
    {
        public string ID { get; set; }
        public Action<Bystander, GameEngine, Villain, List<ICard>> Capture { get; set; } = DefaultCapture;
        public Func<Bystander, GameEngine, Villain, List<ICard>, bool> CaptureCondition { get; set; } = DefaultCaptureCondition;
        public string FlavorText { get; set; }
        public float PrintedVictoryPoints { get; set; } = 1;
        public Action<Bystander, GameEngine, Player, List<ICard>> Rescue { get; set; } = DefaultRescue;
        public Func<Bystander, GameEngine, Player, List<ICard>, bool> RescueCondition { get; set; } = DefaultRescueCondition;
        public string RulesText { get; set; }
        public string Subtitle { get; set; }
        public string Title { get; set; } = "Bystander";
        public Func<IVictoryCard, GameEngine, Player, float> VictoryPoints { get; set; } = DefaultVictoryPoints;

        public static void DefaultCapture(Bystander card, GameEngine game, Villain villain, List<ICard> source)
        {
            throw new NotImplementedException();
        }

        public static bool DefaultCaptureCondition(Bystander card, GameEngine game, Villain villain, List<ICard> source) => true;

        public static void DefaultRescue(Bystander card, GameEngine game, Player player, List<ICard> source)
        {
            throw new NotImplementedException();
        }

        public static bool DefaultRescueCondition(Bystander card, GameEngine game, Player player, List<ICard> source) => true;

        public static float DefaultVictoryPoints(IVictoryCard card, GameEngine game, Player player) => card.PrintedVictoryPoints;

    }
}
