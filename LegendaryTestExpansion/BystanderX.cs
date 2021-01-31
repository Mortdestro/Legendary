using LegendaryEngine;
using LegendaryEngine.CardInterfaces;
using LegendaryEngine.DefaultCards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryTestExpansion
{
    public class BystanderX : DefaultBystander
    {
        public override int PrintedVictoryPoints => 2;
    }
}
