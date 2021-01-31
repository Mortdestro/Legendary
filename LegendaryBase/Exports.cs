using LegendaryEngine;
using LegendaryEngine.CardInterfaces;
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
            BadCards = new Dictionary<string, List<IBadCard>>
            {
                { "Wound", Enumerable.Repeat<IBadCard>(new Wound(), 30).ToList() }
            },
            Bystanders = Enumerable.Repeat<IBystander>(new Bystander(), 30).ToList(),
            StandardHeroes = new Dictionary<string, List<IHero>>
            {
                { "S.H.I.E.L.D. Officer", Enumerable.Repeat<IHero>(new ShieldOfficer(), 30).ToList() }
            },
            StartingCards = Enumerable.Repeat<ICard>(new ShieldAgent(), 8).ToList()
                .Concat(Enumerable.Repeat<ICard>(new ShieldTrooper(), 4)).ToList()
        };
    }
}
