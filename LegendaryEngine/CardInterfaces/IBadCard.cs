using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.CardInterfaces
{
    public interface IBadCard : ICard
    {
        void Healing(GameEngine game, Player player);
        bool HealingCondition(GameEngine game, Player player);
    }
}
