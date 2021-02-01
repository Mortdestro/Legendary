using LegendaryEngine;
using LegendaryEngine.DefaultCards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryVillains
{
    public class NewRecruits : DefaultHero
    {
        public override float PrintedCost => 2;
        public override float PrintedAttackPoints => 1;
        public override string RulesText => "Return this card to the New Recruits Stack. Draw a Card. <i>(You still get this New Recruit's ATTACK.)</i>";
        public override string Subtitle => "Ally";
        public override string Title => "New Recruits";

        public override void Play(GameEngine game, Player player)
        {
            base.Play(game, player);
            player.PlayedCards.Remove(this);
            game.Board.StandardHeroStacks["New Recruits"].Add(this);
            player.Draw();
        }
    }
}
