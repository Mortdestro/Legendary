using LegendaryEngine.CardInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine.DefaultCards
{
    public class DefaultBystander : IBystander
    {
        public string ID { get => "Default Bystander"; set => ID = ID; }
        public virtual string FlavorText => null;
        public virtual float PrintedVictoryPoints => 1;
        public virtual string RulesText => null;
        public virtual string Subtitle => null;
        public virtual string Title => "Bystander";

        public virtual void Capture(GameEngine game, IVillain villain, List<ICard> source)
        {
            throw new NotImplementedException();
        }

        public virtual bool CaptureCondition(GameEngine game, IVillain villain, List<ICard> source) => true;

        public virtual void Rescue(GameEngine game, Player player, List<ICard> source)
        {
            throw new NotImplementedException();
        }

        public virtual bool RescueCondition(GameEngine game, Player player, List<ICard> source) => true;

        public virtual float VictoryPoints(GameEngine game, Player player) => PrintedVictoryPoints;
    }
}
