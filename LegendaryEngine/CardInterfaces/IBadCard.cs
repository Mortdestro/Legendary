using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.CardInterfaces
{
    public interface IBadCard : ICard
    {
        void Healing(Player player, GameState gameState);
        bool HealingCondition(Player player, GameState gameState);
    }
}
