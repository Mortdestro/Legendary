using LegendaryEngine;
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
            BadCards = new Dictionary<string, List<IBadCard>>
            {
                { "Wound", Enumerable.Repeat<IBadCard>(new Wound(), 30).ToList()}
            },
            Bystanders = Enumerable.Repeat<IBystander>(new Bystander(), 30).ToList()
        };
    }
}
