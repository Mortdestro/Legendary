using System;
using System.Collections.Generic;

namespace LegendaryEngine.Cards
{
    public class Card
    {
        public virtual string ID { get; set; }
        public virtual string FlavorText { get; set; }
        public virtual string RulesText { get; set; }
        public virtual string Subtitle { get; set; }
        public virtual string Title { get; set; }
    }
}
