using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.CardInterfaces
{
    public interface IBystander : IVictoryCard
    {
        void Capture(GameEngine game, IVillain villain, List<ICard> source);
        bool CaptureCondition(GameEngine game, IVillain villain, List<ICard> source);
        void Rescue(GameEngine game, Player player, List<ICard> source);
        bool RescueCondition(GameEngine game, Player player, List<ICard> source);
    }
}
