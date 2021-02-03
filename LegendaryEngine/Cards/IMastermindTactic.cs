using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.Cards
{
    public interface IMastermindTactic : IVictoryCard
    {
        void Fight(GameEngine game, Player player);
    }
}
