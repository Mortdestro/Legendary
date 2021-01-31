using LegendaryEngine.CardInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.DefaultCards
{
    public class DefaultBystander : IBystander
    {
        public virtual int PrintedVictoryPoints => 1;
        public string Title => "Bystander";
        public string Subtitle => null;

        public virtual void Capture(IVillain villain, List<ICard> source, GameState gameState)
        {
            throw new NotImplementedException();
        }

        public virtual bool CaptureCondition(IVillain villain, List<ICard> source, GameState gameState) => true;

        public virtual void Rescue(Player player, List<ICard> source, GameState gameState)
        {
            throw new NotImplementedException();
        }

        public virtual bool RescueCondition(Player player, List<ICard> source, GameState gameState) => true;

        public virtual int VictoryPoints(Player player, GameState gameState) => PrintedVictoryPoints;
    }
}
