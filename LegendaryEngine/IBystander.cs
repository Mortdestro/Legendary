using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public interface IBystander : IVictoryCard
    {
        void Capture(Villain villain, GameState gameState);
        bool CaptureCondition(Villain villain, GameState gameState);
        void Rescue(Player player, GameState gameState);
        bool RescueCondition(Player player, GameState gameState);
    }
}
