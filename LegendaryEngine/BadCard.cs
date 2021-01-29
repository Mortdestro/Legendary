using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public abstract class BadCard : ICard
    {
        public abstract void Healing(GameState gameState);
        public abstract bool HealingCondition(GameState gameState);
    }
}
