using System;
using System.Collections.Generic;
using System.Text;
using static LegendaryEngine.Utilities;

namespace LegendaryEngine.Cards
{
    public interface IVictoryCard : ICard
    {
        float PrintedVictoryPoints { get; set; }
        Func<IVictoryCard, GameEngine, Player, float> VictoryPoints { get; set; }
    }
}
