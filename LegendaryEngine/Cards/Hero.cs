using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class Hero : ICard
    {
        public string ID { get; set; }
        public Dictionary<string, Action<Hero, GameEngine, Player>> AdditionalActions { get; set; }
        public string FlavorText { get; set; }
        public float PrintedAttackPoints { get; set; }
        public List<string> PrintedClasses { get; set; } = new List<string>();
        public float PrintedCost { get; set; }
        public float PrintedRecruitPoints { get; set; }
        public List<string> PrintedTeams { get; set; } = new List<string>();
        public string RulesText { get; set; }
        public string Subtitle { get; set; } = "Hero";
        public string Title { get; set; } = "Hero";

        public Func<Hero, GameEngine, Player, List<string>> Classes { get; set; } = DefaultClasses;
        public Func<Hero, GameEngine, Player, float> Cost { get; set; } = DefaultCost;
        public Func<Hero, GameEngine, Player, float> AttackPoints { get; set; } = DefaultAttackPoints;
        public Action<Hero, GameEngine, Player> Play { get; set; } = DefaultPlay;
        public Func<Hero, GameEngine, Player, bool> PlayCondition { get; set; } = DefaultPlayCondition;
        public Func<Hero, GameEngine, Player, float> RecruitPoints { get; set; } = DefaultRecruitPoints;
        public Func<Hero, GameEngine, Player, List<string>> Teams { get; set; } = DefaultTeams;

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
