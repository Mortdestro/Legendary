using LegendaryEngine.CardInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.DefaultCards
{
    public class DefaultBadCard : IBadCard
    {
        public virtual string Title => "Bad";
        public virtual string Subtitle => null;

        public virtual void Healing(Player player, GameState gameState) { }

        public virtual bool HealingCondition(Player player, GameState gameState) => player == gameState.CurrentTurn.Player;
    }
}
