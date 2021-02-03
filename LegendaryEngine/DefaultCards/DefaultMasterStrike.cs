using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.DefaultCards
{
    public class DefaultMasterStrike : IMasterStrike
    {
        public string ID { get => "Default Strike"; set => ID = ID; }
        public virtual string FlavorText => null;
        public virtual string RulesText => null;
        public virtual string Subtitle => null;
        public virtual string Title => "Master Strike";
    }
}
