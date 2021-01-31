using LegendaryEngine;
using LegendaryEngine.CardInterfaces;
using LegendaryEngine.DefaultCards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryHeroes
{
    public class ShieldOfficer : DefaultHero
    {
        public override float PrintedCost => 3;
        public override float PrintedRecruitPoints => 2;
        public override string Title => "S.H.I.E.L.D. Officer";
        public override string Subtitle => "Maria Hill";
        public override string[] PrintedTeams => new string[] { "SHIELD" };
    }
}
