using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.DefaultCards
{
    public class DefaultMastermindTactic : IMastermindTactic
    {
        public string ID { get => "Default Tactic"; set => ID = ID; }
        public virtual string FlavorText => null;
        public virtual float PrintedVictoryPoints { get => 5; set => PrintedVictoryPoints = PrintedVictoryPoints; }
        public virtual string RulesText => null;
        public virtual string Subtitle => "Tactic";
        public virtual string Title => "Mastermind";

        public virtual Func<IVictoryCard, GameEngine, Player, float> VictoryPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void Fight(GameEngine game, Player player) { }
    }
}
