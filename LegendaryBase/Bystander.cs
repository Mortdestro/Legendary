using LegendaryEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryHeroes
{
    public class Bystander : IBystander
    {
        public virtual int PrintedVictoryPoints => 1;

        public virtual void Capture(Villain villain, GameState gameState)
        {
            throw new NotImplementedException();
        }

        public virtual bool CaptureCondition(Villain villain, GameState gameState)
        {
            return true;
        }

        public virtual void Rescue(Player player, GameState gameState)
        {
            throw new NotImplementedException();
        }

        public virtual bool RescueCondition(Player player, GameState gameState)
        {
            throw new NotImplementedException();
        }

        public virtual int VictoryPoints(Player player, GameState gameState)
        {
            return PrintedVictoryPoints;
        }
    }
}
