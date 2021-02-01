using LegendaryEngine.CardInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.DefaultCards
{
    public class DefaultBadCard : IBadCard
    {
        public virtual string FlavorText => throw new NotImplementedException();
        public virtual string RulesText => throw new NotImplementedException();
        public virtual string Subtitle => null;
        public virtual string Title => "Bad";

        public virtual void Healing(GameEngine game, Player player) { }

        public virtual bool HealingCondition(GameEngine game, Player player) => player == game.CurrentTurn.Player;
    }
}
