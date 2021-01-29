using LegendaryEngine;
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
            BadCards = new Dictionary<string, List<IBadCard>>
            {
                { "Wound", Enumerable.Repeat<IBadCard>(new BadCardX(), 15).ToList()}
            },
            Bystanders = Enumerable.Repeat<IBystander>(new BystanderX(), 4).ToList()
        };
    }
}
