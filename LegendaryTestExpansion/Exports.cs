﻿using LegendaryEngine;
using LegendaryEngine.CardInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendaryTestExpansion
{
    public static class Exports
    {
        public static readonly Module Module = new Module
        {
            Name = "Test Expansion",
            BadCards = new Dictionary<string, List<BadCard>>
            {
                { "Wound", Enumerable.Repeat(StackCards.CreateBadCardX(), 15).ToList() }
            },
            Bystanders = Enumerable.Repeat<IBystander>(new BystanderX(), 4).ToList(),
            StandardHeroes = new Dictionary<string, List<IHero>>
            {
                { "Hero X", Enumerable.Repeat<IHero>(new HeroX(), 30).ToList() }
            }
        };
    }
}
