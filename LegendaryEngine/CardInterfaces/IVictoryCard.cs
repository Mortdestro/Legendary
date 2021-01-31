using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.CardInterfaces
{
    public interface IVictoryCard : ICard
    {
        int PrintedVictoryPoints { get; }
        int VictoryPoints(Player player, GameState gameState);
    }
}
