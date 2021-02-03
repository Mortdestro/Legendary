using System;
using System.Collections.Generic;

namespace LegendaryEngine.Cards
{
    public interface ICard
    {
        string ID { get; set; }
        string FlavorText { get; }
        string RulesText { get; }
        string Subtitle { get; }
        string Title { get; }
    }
}
