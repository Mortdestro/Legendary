using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class Bystander : VictoryCard
    {
        public override float PrintedVictoryPoints { get; set; } = 1;
        public override string Title { get; set; } = "Bystander";

        public virtual Action<Bystander, GameEngine, Villain, List<Card>> Capture { get; set; } = DefaultCapture;
        public virtual Func<Bystander, GameEngine, Villain, List<Card>, bool> CaptureCondition { get; set; } = DefaultCaptureCondition;
        public virtual Action<Bystander, GameEngine, Player, List<Card>> Rescue { get; set; } = DefaultRescue;
        public virtual Func<Bystander, GameEngine, Player, List<Card>, bool> RescueCondition { get; set; } = DefaultRescueCondition;

        public static void DefaultCapture(Bystander card, GameEngine game, Villain villain, List<Card> source)
        {
            throw new NotImplementedException();
        }

        public static bool DefaultCaptureCondition(Bystander card, GameEngine game, Villain villain, List<Card> source) => true;

        public static void DefaultRescue(Bystander card, GameEngine game, Player player, List<Card> source)
        {
            throw new NotImplementedException();
        }

        public static bool DefaultRescueCondition(Bystander card, GameEngine game, Player player, List<Card> source) => true;
    }
}
