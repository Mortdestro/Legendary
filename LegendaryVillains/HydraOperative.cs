using LegendaryEngine.DefaultCards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryVillains
{
    public class HydraOperative : DefaultHero
    {
        public override float PrintedRecruitPoints => 1;
        public override List<string> PrintedTeams => new List<string> { "HYDRA" };
        public override string Subtitle => "Ally";
        public override string Title => "HYDRA Operative";
    }
}
