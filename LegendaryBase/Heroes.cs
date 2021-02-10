using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryHeroes
{
    public class Heroes
    {
        #region SHIELD
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
                HeroName = "Maria Hill",
                PrintedTeams = new List<string> { "SHIELD" }
            };
        }
        #endregion

        #region Avengers

        #region Captain America
        public static Hero CreateCaptainAmericaADayLikeAnyOther()
        {
            return new Hero
            {
                ID = "ADayLikeAnyOther",
                // @TODO: AttackPoints,
                HeroName = "Captain America",
                PrintedAttackPoints = 3,
                PrintedClasses = new List<string> { "COVERT" },
                PrintedCost = 7,
                PrintedTeams = new List<string> { "AVENGERS" },
                RulesText = "AVENGERS: You get <b>+3 ATTACK</b> for each other AVENGERS Hero you played this turn.",
                Title = "A Day Like Any Other"
            };
        }

        public static Hero CreateCaptainAmericaDivingBlock()
        {
            return new Hero
            {
                // @TODO: reveal to avoid wound
                ID = "DivingBlock",
                HeroName = "Captain America",
                PrintedAttackPoints = 4,
                PrintedClasses = new List<string> { "TECH" },
                PrintedCost = 6,
                PrintedTeams = new List<string> { "AVENGERS" },
                RulesText = "If you would gain a Wound, you may reveal this card and draw a card instead.",
                Title = "Diving Block"
            };
        }

        public static Hero CreateCaptainAmericaPerfectTeamwork()
        {
            return new Hero
            {
                ID = "PerfectTeamwork",
                // @TODO: AttackPoints,
                HeroName = "Captain America",
                PrintedClasses = new List<string> { "STRENGTH" },
                PrintedCost = 4,
                PrintedTeams = new List<string> { "AVENGERS" },
                RulesText = "You get <b>+1 ATTACK</b> for each color of Hero you have.",
                Title = "Perfect Teamwork"
            };
        }

        public static Hero CreateCaptainAmericaAvengersAssemble()
        {
            return new Hero
            {
                ID = "AvengersAssemble",
                HeroName = "Captain America",
                PrintedClasses = new List<string> { "INSTINCT" },
                PrintedCost = 3,
                PrintedTeams = new List<string> { "AVENGERS" },
                // @TODO: RecruitPoints,
                RulesText = "You get <b>+1 RECRUIT</b> for each color of Hero you have.",
                Title = "Avengers Assemble"
            };
        }
        #endregion

        #region Hawkeye
        public static Hero CreateHawkeyeImpossibleTrickShot()
        {
            return new Hero
            {
                ID = "ImpossibleTrickShot",
                HeroName = "Hawkeye",
                // @TODO: Play,
                PrintedAttackPoints = 5,
                PrintedClasses = new List<string> { "TECH" },
                PrintedCost = 7,
                PrintedTeams = new List<string> { "AVENGERS" },
                RulesText = "Whenever you defeat a Villain or Mastermind this turn, rescue three Bystanders.",
                Title = "Impossible Trick Shot"
            };
        }

        public static Hero CreateHawkeyeCoveringFire()
        {
            return new Hero
            {
                ID = "CoveringFire",
                HeroName = "Hawkeye",
                PrintedAttackPoints = 3,
                PrintedClasses = new List<string> { "TECH" },
                PrintedCost = 5,
                PrintedTeams = new List<string> { "AVENGERS" },
                RulesText = "TECH: Choose one: each other player draws a card or each other player discards a card.",
                Title = "Covering Fire"
            };
        }

        public static Hero CreateHawkeyeTeamPlayer()
        {
            return new Hero
            {
                ID = "TeamPlayer",
                // @TODO: AttackPoints,
                FlavorText = "\"You line 'em up and I'll knock 'em down...\"",
                HeroName = "Hawkeye",
                PrintedAttackPoints = 2,
                PrintedClasses = new List<string> { "TECH" },
                PrintedCost = 4,
                PrintedTeams = new List<string> { "AVENGERS" },
                RulesText = "AVENGERS: You get <b>+1 ATTACK</b>.",
                Title = "Team Player"
            };
        }

        public static Hero CreateHawkeyeQuickDraw()
        {
            return new Hero
            {
                ID = "QuickDraw",
                FlavorText = "Against robots, Hawkeye's first shot is a warning shot. In the face.",
                HeroName = "Hawkeye",
                // @TODO: Play,
                PrintedAttackPoints = 1,
                PrintedClasses = new List<string> { "INSTINCT" },
                PrintedCost = 3,
                PrintedTeams = new List<string> { "AVENGERS" },
                RulesText = "Draw a card.",
                Title = "Quick Draw"
            };
        }
        #endregion

        #region Iron Man
        public static Hero CreateIronManQuantumBreakthrough()
        {
            return new Hero
            {
                ID = "QuantumBreakthrough",
                HeroName = "Iron Man",
                // @TODO: Play,
                PrintedClasses = new List<string> { "TECH" },
                PrintedCost = 7,
                PrintedTeams = new List<string> { "AVENGERS" },
                RulesText = "Draw two cards.\r\n" +
                "TECH: Draw two more cards.",
                Title = "Quantum Breakthrough"
            };
        }

        public static Hero CreateIronManArcReactor()
        {
            return new Hero
            {
                ID = "ArcReactor",
                // @TODO: AttackPoints,
                HeroName = "Iron Man",
                PrintedAttackPoints = 3,
                PrintedClasses = new List<string> { "TECH" },
                PrintedCost = 5,
                PrintedTeams = new List<string> { "AVENGERS" },
                RulesText = "TECH: You get <b>+1 ATTACK</b> for each other TECH Hero you played this turn.",
                Title = "Arc Reactor"
            };
        }

        public static Hero CreateIronManRepulsorRays()
        {
            return new Hero
            {
                ID = "RepulsorRays",
                // @TODO: AttackPoints,
                FlavorText = "Repulsor ray technology has many peaceful applications. This is not one of them.",
                HeroName = "Iron Man",
                PrintedAttackPoints = 2,
                PrintedClasses = new List<string> { "RANGED" },
                PrintedCost = 3,
                PrintedTeams = new List<string> { "AVENGERS" },
                RulesText = "RANGED: You get <b>+1 ATTACK</b>",
                Title = "Repulsor Rays"
            };
        }

        public static Hero CreateIronManEndlessInvention()
        {
            return new Hero
            {
                ID = "EndlessInvention",
                HeroName = "Iron Man",
                // @TODO: Play,
                PrintedClasses = new List<string> { "TECH" },
                PrintedCost = 3,
                PrintedTeams = new List<string> { "AVENGERS" },
                RulesText = "Draw a card.\r\n" +
                "TECH: Draw another card.",
                Title = "Endless Invention"
            };
        }
        #endregion

        #endregion

        #region Spider Friends

        #region Spider-Man
        public static Hero CreateSpiderManTheAmazingSpiderMan()
        {
            return new Hero
            {
                ID = "TheAmazingSpiderMan",
                HeroName = "Spider-Man",
                // @TODO: Play,
                PrintedClasses = new List<string> { "COVERT" },
                PrintedCost = 2,
                PrintedTeams = new List<string> { "SPIDER FRIENDS" },
                RulesText = "Reveal the top three cards of your deck. Put any that cost <b>2 COST</b> or less into your hand. Put the rest back in any order.",
                Title = "The Amazing Spider-Man"
            };
        }

        public static Hero CreateSpiderManWebShooters()
        {
            return new Hero
            {
                ID = "WebShooters",
                HeroName = "Spider-Man",
                // @TODO: Play,
                PrintedClasses = new List<string> { "TECH" },
                PrintedCost = 2,
                PrintedTeams = new List<string> { "SPIDER FRIENDS" },
                RulesText = "Rescue a Bystander.\r\n" +
                "Reveal the top card of your deck. If that card costs <b>2 COST</b> or less, draw it.",
                Title = "Web-Shooters"
            };
        }

        public static Hero CreateSpiderManGreatResponsibility()
        {
            return new Hero
            {
                ID = "GreatResponsibility",
                HeroName = "Spider-Man",
                // @TODO: Play,
                PrintedAttackPoints = 1,
                PrintedClasses = new List<string> { "INSTINCT" },
                PrintedCost = 2,
                PrintedTeams = new List<string> { "SPIDER FRIENDS" },
                RulesText = "Reveal the top card of your deck. If that card costs <b>2 COST</b> or less, draw it.",
                Title = "Great Responsibility"
            };
        }

        public static Hero CreateSpiderManAstonishingStrength()
        {
            return new Hero
            {
                ID = "AstonishingStrength",
                HeroName = "Spider-Man",
                // @TODO: Play,
                PrintedClasses = new List<string> { "STRENGTH" },
                PrintedCost = 2,
                PrintedRecruitPoints = 1,
                PrintedTeams = new List<string> { "SPIDER FRIENDS" },
                RulesText = "Reveal the top card of your deck. If that card costs <b>2 COST</b> or less, draw it.",
                Title = "Astonishing Strength"
            };
        }
        #endregion

        #endregion

        #region X-Men

        #region Cyclops
        public static Hero CreateCyclopsXMenUnited()
        {
            return new Hero
            {
                ID = "XMenUnited",
                // @TODO: AttackPoints,
                HeroName = "Cyclops",
                PrintedAttackPoints = 6,
                PrintedClasses = new List<string> { "RANGED" },
                PrintedCost = 8,
                PrintedTeams = new List<string> { "X-MEN" },
                RulesText = "X-MEN: You get <b>+2 ATTACK</b> for each other X-MEN Hero you played this turn.",
                Title = "Optic Blast"
            };
        }

        public static Hero CreateCyclopsUnendingEnergy()
        {
            return new Hero
            {
                ID = "UnendingEnergy",
                // @TODO: Discard,
                HeroName = "Cyclops",
                PrintedAttackPoints = 4,
                PrintedClasses = new List<string> { "RANGED" },
                PrintedCost = 6,
                PrintedTeams = new List<string> { "X-MEN" },
                RulesText = "If a card effect makes you discard this card, you may return this card to your hand.",
                Title = "Optic Blast"
            };
        }

        public static Hero CreateCyclopsOpticBlast()
        {
            return new Hero
            {
                ID = "OpticBlast",
                HeroName = "Cyclops",
                // @TODO: PlayCondition,
                PrintedAttackPoints = 3,
                PrintedClasses = new List<string> { "RANGED" },
                PrintedCost = 3,
                PrintedTeams = new List<string> { "X-MEN" },
                RulesText = "To play this card, you must discard a card from your hand.",
                Title = "Optic Blast"
            };
        }

        public static Hero CreateCyclopsDetermination()
        {
            return new Hero
            {
                ID = "Determination",
                HeroName = "Cyclops",
                // @TODO: PlayCondition,
                PrintedClasses = new List<string> { "STRENGTH" },
                PrintedCost = 2,
                PrintedRecruitPoints = 3,
                PrintedTeams = new List<string> { "X-MEN" },
                RulesText = "To play this card, you must discard a card from your hand.",
                Title = "Determination"
            };
        }

        #endregion

        #endregion

        #region Private Methods

        #endregion
    }
}
