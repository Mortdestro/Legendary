using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.DefaultCards
{
    public class DefaultMastermind : IMastermind
    {
        public string ID { get => "Default Mastermind"; set => ID = ID; }
        public virtual string FlavorText => null;
        public virtual string RulesText => null;
        public virtual string Subtitle => null;
        public virtual string Title => "Mastermind";

        public virtual bool FightCondition(GameEngine game, Player player) => true;

        public virtual void MasterStrike(GameEngine game, Player player) { }
    }
}
