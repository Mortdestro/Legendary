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
            StandardHeroes = new Dictionary<string, List<Hero>>
            {
                { "S.H.I.E.L.D. Officer", Enumerable.Repeat(Heroes.CreateShieldOfficer(), 30).ToList() }
            },
            StartingCards = Enumerable.Repeat<ICard>(Heroes.CreateShieldAgent(), 8).ToList()
                .Concat(Enumerable.Repeat<ICard>(Heroes.CreateShieldTrooper(), 4)).ToList()
        };
    }
}
