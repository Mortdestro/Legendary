using LegendaryEngine.CardInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.DefaultCards
{
    public class DefaultHero : IHero
    {
        public string ID { get => "Default Hero"; set => ID = ID; }
        public virtual Dictionary<string, Action<GameEngine, Player>> AdditionalActions => null;
        public virtual float PrintedAttackPoints => 0;
        public virtual float PrintedCost => 0;
        public virtual float PrintedRecruitPoints => 0;
        public virtual string RulesText => null;
        public virtual string FlavorText => null;
        public virtual string Title => "Hero";
        public virtual string Subtitle => "Hero";
        public virtual List<string> PrintedClasses => new List<string>();
        public virtual List<string> PrintedTeams => new List<string>();

        public virtual float AttackPoints(GameEngine game, Player player) => PrintedAttackPoints;

        public virtual List<string> Classes(GameEngine game, Player player) => PrintedClasses;

        public virtual float Cost(GameEngine game, Player player) => PrintedCost;

        public virtual void Play(GameEngine game, Player player)
        {
            // move from hand to played, add attack points and recruit points to total, increment classes and teams
            throw new NotImplementedException();
        }

        public virtual bool PlayCondition(GameEngine game, Player player) => true;

        public virtual float RecruitPoints(GameEngine game, Player player) => PrintedRecruitPoints;

        public virtual List<string> Teams(GameEngine game, Player player) => PrintedTeams;
    }
}
