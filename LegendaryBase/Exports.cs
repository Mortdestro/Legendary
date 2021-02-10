using LegendaryEngine;
using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendaryHeroes
{
    public static class Exports
    {
        public static readonly Module Module = new Module
        {
            Name = "Marvel Legendary",
            BadCards = new Dictionary<string, List<BadCard>>
            {
                { "Wound", Enumerable.Repeat(BadCards.CreateWound(), 30).ToList() }
            },
            Bystanders = Enumerable.Repeat(Bystanders.CreateBystander(), 30).ToList(),
            Heroes = new Dictionary<string, List<Hero>>
            {
                { "Captain America", new List<Hero>() { Heroes.CreateCaptainAmericaADayLikeAnyOther() }
                    .Concat(Enumerable.Repeat(Heroes.CreateCaptainAmericaDivingBlock(), 3))
                    .Concat(Enumerable.Repeat(Heroes.CreateCaptainAmericaPerfectTeamwork(), 5))
                    .Concat(Enumerable.Repeat(Heroes.CreateCaptainAmericaAvengersAssemble(), 5))
                    .ToList()
                    },
                { "Cyclops", new List<Hero>() { Heroes.CreateCyclopsXMenUnited() }
                    .Concat(Enumerable.Repeat(Heroes.CreateCyclopsUnendingEnergy(), 3))
                    .Concat(Enumerable.Repeat(Heroes.CreateCyclopsOpticBlast(), 5))
                    .Concat(Enumerable.Repeat(Heroes.CreateCyclopsDetermination(), 5))
                    .ToList()
                    },
                { "Hawkeye", new List<Hero>() { Heroes.CreateHawkeyeImpossibleTrickShot() }
                    .Concat(Enumerable.Repeat(Heroes.CreateHawkeyeCoveringFire(), 3))
                    .Concat(Enumerable.Repeat(Heroes.CreateHawkeyeTeamPlayer(), 5))
                    .Concat(Enumerable.Repeat(Heroes.CreateHawkeyeQuickDraw(), 5))
                    .ToList()
                    },
                { "Iron Man", new List<Hero>() { Heroes.CreateIronManQuantumBreakthrough() }
                    .Concat(Enumerable.Repeat(Heroes.CreateIronManArcReactor(), 3))
                    .Concat(Enumerable.Repeat(Heroes.CreateIronManRepulsorRays(), 5))
                    .Concat(Enumerable.Repeat(Heroes.CreateIronManEndlessInvention(), 5))
                    .ToList()
                    },
                { "Spider-Man", new List<Hero>() { Heroes.CreateSpiderManTheAmazingSpiderMan() }
                    .Concat(Enumerable.Repeat(Heroes.CreateSpiderManWebShooters(), 3))
                    .Concat(Enumerable.Repeat(Heroes.CreateSpiderManGreatResponsibility(), 5))
                    .Concat(Enumerable.Repeat(Heroes.CreateSpiderManAstonishingStrength(), 5))
                    .ToList()
                    }
            },
            StandardHeroes = new Dictionary<string, List<Hero>>
            {
                { "S.H.I.E.L.D. Officer", Enumerable.Repeat(Heroes.CreateShieldOfficer(), 30).ToList() }
            },
            StartingCards = Enumerable.Repeat<Card>(Heroes.CreateShieldAgent(), 8).ToList()
                .Concat(Enumerable.Repeat<Card>(Heroes.CreateShieldTrooper(), 4)).ToList()
        };
    }
}
