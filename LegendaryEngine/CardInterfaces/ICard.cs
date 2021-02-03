using System;
using System.Collections.Generic;

namespace LegendaryEngine.CardInterfaces
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
