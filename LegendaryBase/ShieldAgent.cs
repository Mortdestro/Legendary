using LegendaryEngine.DefaultCards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryHeroes
{
    public class ShieldAgent : DefaultHero
    {
        public override float PrintedRecruitPoints => 1;
        public override string Title => "S.H.I.E.L.D. Agent";
        public override List<string> PrintedTeams => new List<string> { "SHIELD" };
    }
}
