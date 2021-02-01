using LegendaryEngine.DefaultCards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryHeroes
{
    public class ShieldTrooper : DefaultHero
    {
        public override float PrintedAttackPoints => 1;
        public override string Title => "S.H.I.E.L.D. Trooper";
        public override List<string> PrintedTeams => new List<string> { "SHIELD" };
    }
}
