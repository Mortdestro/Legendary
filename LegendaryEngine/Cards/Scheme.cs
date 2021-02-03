using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public class Scheme : ICard
    {
        // Setup
        public string ID { get; set; }

        public string FlavorText { get; set; }

        public string RulesText { get; set; }

        public string Subtitle { get; set; }

        public string Title { get; set; }
    }
}
