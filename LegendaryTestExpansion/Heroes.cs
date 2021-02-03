using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryTestExpansion
{
    public class Heroes
    {
        public static Hero CreateHeroX()
        {
            return new Hero
            {
                ID = "HeroX",
                PrintedCost = 3,
                PrintedAttackPoints = 1,
                PrintedRecruitPoints = 1,
                Title = "S.H.I.E.L.D. Hero X",
                PrintedTeams = new List<string> { "SHIELD" }
            };
        }
    }
}
