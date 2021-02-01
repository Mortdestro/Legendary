using LegendaryEngine;
using LegendaryEngine.CardInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendaryVillains
{
    public static class Exports
    {
        public static readonly Module Module = new Module
        {
            Name = "Marvel Legendary Villains",
            BadCards = new Dictionary<string, List<IBadCard>>
            {
                { "Bindings", Enumerable.Repeat<IBadCard>(new Bindings(), 30).ToList() }
            },
            Bystanders = Enumerable.Repeat<IBystander>(new Bystander(), 30).ToList(),
            StandardHeroes = new Dictionary<string, List<IHero>>
            {
                { "Madame HYDRA", Enumerable.Repeat<IHero>(new MadameHydra(), 15).ToList() },
                { "New Recruits", Enumerable.Repeat<IHero>(new NewRecruits(), 15).ToList() }
            },
            StartingCards = Enumerable.Repeat<ICard>(new HydraOperative(), 8).ToList()
                .Concat(Enumerable.Repeat<ICard>(new HydraSoldier(), 4)).ToList()
        };
    }
}
