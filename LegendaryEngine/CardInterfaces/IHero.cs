using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.CardInterfaces
{
    public interface IHero : ICard
    {
        float PrintedCost { get; }
        float PrintedAttackPoints { get; }
        float PrintedRecruitPoints { get; }
        string[] PrintedClasses { get; }
        string[] PrintedTeams { get; }
        string RulesText { get; }

        string[] Classes(Player player, GameState gameState);
        float Cost(Player player, GameState gameState);
        float AttackPoints(Player player, GameState gameState);
        void Play(Player player, GameState gameState);
        bool PlayCondition(Player player, GameState gameState);
        float RecruitPoints(Player player, GameState gameState);
        string[] Teams(Player player, GameState gameState);
    }
}
