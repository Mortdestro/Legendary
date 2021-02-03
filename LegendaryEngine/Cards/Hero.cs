using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class Hero : Card
    {
        public override string Subtitle { get; set; } = "Hero";
        public override string Title { get; set; } = "Hero";

        public virtual Dictionary<string, Action<Hero, GameEngine, Player>> AdditionalActions { get; set; }
        public virtual Func<Hero, GameEngine, Player, float> AttackPoints { get; set; } = DefaultAttackPoints;
        public virtual Func<Hero, GameEngine, Player, List<string>> Classes { get; set; } = DefaultClasses;
        public virtual Func<Hero, GameEngine, Player, float> Cost { get; set; } = DefaultCost;
        public virtual Action<Hero, GameEngine, Player> Play { get; set; } = DefaultPlay;
        public virtual Func<Hero, GameEngine, Player, bool> PlayCondition { get; set; } = DefaultPlayCondition;
        public virtual float PrintedAttackPoints { get; set; }
        public virtual List<string> PrintedClasses { get; set; } = new List<string>();
        public virtual float PrintedCost { get; set; }
        public virtual float PrintedRecruitPoints { get; set; }
        public virtual List<string> PrintedTeams { get; set; } = new List<string>();
        public virtual Func<Hero, GameEngine, Player, float> RecruitPoints { get; set; } = DefaultRecruitPoints;
        public virtual Func<Hero, GameEngine, Player, List<string>> Teams { get; set; } = DefaultTeams;

        public static float DefaultAttackPoints(Hero card, GameEngine game, Player player) => card.PrintedAttackPoints;

        public static List<string> DefaultClasses(Hero card, GameEngine game, Player player) => card.PrintedClasses;

        public static float DefaultCost(Hero card, GameEngine game, Player player) => card.PrintedCost;

        public static void DefaultPlay(Hero card, GameEngine game, Player player)
        {
            // move from hand to played, add attack points and recruit points to total, increment classes and teams
            throw new NotImplementedException();
        }

        public static bool DefaultPlayCondition(Hero card, GameEngine game, Player player) => true;

        public static float DefaultRecruitPoints(Hero card, GameEngine game, Player player) => card.PrintedRecruitPoints;

        public static List<string> DefaultTeams(Hero card, GameEngine game, Player player) => card.PrintedTeams;
    }
}
