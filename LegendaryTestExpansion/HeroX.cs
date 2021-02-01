using LegendaryEngine.DefaultCards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryTestExpansion
{
    public class HeroX : DefaultHero
    {
        public override float PrintedCost => 3;
        public override float PrintedAttackPoints => 1;
        public override float PrintedRecruitPoints => 1;
        public override string Title => "S.H.I.E.L.D. Hero X";
        public override List<string> PrintedTeams => new List<string> { "SHIELD" };
    }
}
