using LegendaryEngine;
using LegendaryEngine.Cards;
using LegendaryEngine.DefaultCards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryVillains
{
    public class MadameHydra : DefaultHero
    {
        public override Dictionary<string, Action<GameEngine, Player>> AdditionalActions => new Dictionary<string, Action<GameEngine, Player>>
        {
            {"Dodge", this.Dodge}
        };
        public override float PrintedCost => 3;
        public override float PrintedRecruitPoints => 2;
        public override List<string> PrintedTeams => new List<string> { "HYDRA" };
        public override string RulesText => "<b>Dodge</b>\r\n" +
            "To play this card, you must discard a card from your hand.";
        public override string Subtitle => "Viper";
        public override string Title => "Madame HYDRA";

        public override bool PlayCondition(GameEngine game, Player player)
        {
            // Force a discard
            throw new NotImplementedException();
        }
    }
}
