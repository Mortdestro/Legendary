using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public interface IHero : ICard
    {
        Dictionary<string, Action<GameEngine, Player>> AdditionalActions { get; }
        float PrintedAttackPoints { get; }
        List<string> PrintedClasses { get; }
        float PrintedCost { get; }
        float PrintedRecruitPoints { get; }
        List<string> PrintedTeams { get; }

        List<string> Classes(GameEngine game, Player player);
        float Cost(GameEngine game, Player player);
        float AttackPoints(GameEngine game, Player player);
        void Play(GameEngine game, Player player);
        bool PlayCondition(GameEngine game, Player player);
        float RecruitPoints(GameEngine game, Player player);
        List<string> Teams(GameEngine game, Player player);
    }
}
