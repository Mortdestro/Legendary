using LegendaryEngine;
using LegendaryHeroes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryTestExpansion
{
    public class BystanderX : Bystander
    {
        public override int PrintedVictoryPoints => 2;

        public override void Rescue(Player player, GameState gameState)
        {
            throw new NotImplementedException();
        }
    }
}
