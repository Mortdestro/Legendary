using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryHeroes
{
    public class Heroes
    {
        public static Hero CreateShieldAgent()
        {
            return new Hero
            {
                ID = "ShieldAgent",
                PrintedRecruitPoints = 1,
                PrintedTeams = new List<string> { "SHIELD" },
                Title = "S.H.I.E.L.D. Agent"
            };
        }

        public static Hero CreateShieldTrooper()
        {
            return new Hero
            {
                ID = "ShieldTrooper",
                PrintedAttackPoints = 1,
                PrintedTeams = new List<string> { "SHIELD" },
                Title = "S.H.I.E.L.D. Trooper"
            };
        }

        public static Hero CreateShieldOfficer()
        {
            return new Hero
            {
                ID = "ShieldOfficer",
                PrintedCost = 3,
                PrintedRecruitPoints = 2,
                Title = "S.H.I.E.L.D. Officer",
                Subtitle = "Maria Hill",
                PrintedTeams = new List<string> { "SHIELD" }
            };
        }
    }
}
