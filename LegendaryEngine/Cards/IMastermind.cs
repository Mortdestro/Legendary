using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public interface IMastermind : ICard
    {
        // Always leads
        // Setup
        bool FightCondition(GameEngine game, Player player);
        void MasterStrike(GameEngine game, Player player);
    }
}
