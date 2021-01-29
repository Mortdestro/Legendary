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
            BadCards = new Dictionary<string, List<BadCard>>
            {
                { "Wound", Enumerable.Repeat<BadCard>(new BadCardX(), 15).ToList()}
            }
        };
    }
}
