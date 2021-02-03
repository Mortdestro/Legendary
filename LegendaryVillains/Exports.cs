using LegendaryEngine;
using LegendaryEngine.Cards;
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
            BadCards = new Dictionary<string, List<BadCard>>
            {
                { "Bindings", Enumerable.Repeat(BadCards.CreateBindings(), 30).ToList() }
            },
            Bystanders = Enumerable.Repeat(Bystanders.CreateBystander(), 30).ToList(),
            StandardHeroes = new Dictionary<string, List<Hero>>
            {
                { "Madame HYDRA", Enumerable.Repeat(Heroes.CreateMadameHydra(), 15).ToList() },
                { "New Recruits", Enumerable.Repeat(Heroes.CreateNewRecruits(), 15).ToList() }
            },
            StartingCards = Enumerable.Repeat<ICard>(Heroes.CreateHydraOperative(), 8).ToList()
                .Concat(Enumerable.Repeat<ICard>(Heroes.CreateHydraSoldier(), 4)).ToList()
        };
    }
}
