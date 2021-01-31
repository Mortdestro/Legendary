using LegendaryEngine.CardInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.DefaultCards
{
    public class DefaultHero : IHero
    {
        public virtual float PrintedAttackPoints => 0;
        public virtual float PrintedCost => 0;
        public virtual float PrintedRecruitPoints => 0;
        public virtual string RulesText => null;
        public virtual string Title => "Hero";
        public virtual string Subtitle => "Hero";
        public virtual string[] PrintedClasses => new string[0];
        public virtual string[] PrintedTeams => new string[0];

        public virtual float AttackPoints(Player player, GameState gameState) => PrintedAttackPoints;

        public virtual string[] Classes(Player player, GameState gameState) => PrintedClasses;

        public virtual float Cost(Player player, GameState gameState) => PrintedCost;

        public virtual void Play(Player player, GameState gameState)
        {
            // move from hand to played, add attack points and recruit points to total
            throw new NotImplementedException();
        }

        public virtual bool PlayCondition(Player player, GameState gameState) => true;

        public virtual float RecruitPoints(Player player, GameState gameState) => PrintedRecruitPoints;

        public virtual string[] Teams(Player player, GameState gameState) => PrintedTeams;
    }
}
