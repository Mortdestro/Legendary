using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class Villain : VictoryCard
    {
        public override string Subtitle
        {
            get => Henchman ? "Henchman Villain" : "Villain - " + VillainGroup;
            set => VillainGroup = Henchman ? VillainGroup : value.StartsWith("Villain - ") ? value.Substring("Villain - ".Length) : value;
        }
        public override string Title { get; set; } = "Villain";

        public virtual Action<Villain, GameEngine, Player> Ambush { get; set; } = DefaultAmbush;
        public virtual Func<Villain, GameEngine, Player, float> AttackPoints { get; set; } = DefaultAttackPoints;
        public virtual Action<Villain, GameEngine, Player> Escape { get; set; } = DefaultEscape;
        public virtual Action<Villain, GameEngine, Player> Fight { get; set; } = DefaultFight;
        public virtual Func<Villain, GameEngine, Player, bool> FightCondition { get; set; } = DefaultFightCondition;
        public virtual bool Henchman { get; set; } = false;
        public virtual float PrintedAttackPoints { get; set; }
        public virtual string VillainGroup { get; set; }

        public static void DefaultAmbush(Villain card, GameEngine game, Player player) { }
        public static float DefaultAttackPoints(Villain card, GameEngine game, Player player) => card.PrintedAttackPoints;
        public static void DefaultEscape(Villain card, GameEngine game, Player player) { }
        public static void DefaultFight(Villain card, GameEngine game, Player player) { /* @TODO */ }
        public static bool DefaultFightCondition(Villain card, GameEngine game, Player player) => true;
    }
}
