using System;
using System.Collections.Generic;
using System.Text;
using static LegendaryEngine.Utilities;

namespace LegendaryEngine.CardInterfaces
{
    public interface IVictoryCard : ICard
    {
        float PrintedVictoryPoints { get; }
        float VictoryPoints(GameEngine game, Player player);
    }
}
