using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.CardInterfaces
{
    public interface IBystander : IVictoryCard
    {
        void Capture(IVillain villain, List<ICard> source, GameState gameState);
        bool CaptureCondition(IVillain villain, List<ICard> source, GameState gameState);
        void Rescue(Player player, List<ICard> source, GameState gameState);
        bool RescueCondition(Player player, List<ICard> source, GameState gameState);
    }
}
