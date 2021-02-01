using System;

namespace LegendaryEngine.CardInterfaces
{
    public interface ICard
    {
        string FlavorText { get; }
        string RulesText { get; }
        string Subtitle { get; }
        string Title { get; }
    }
}
