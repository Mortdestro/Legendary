using LegendaryEngine;
using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryVillains
{
    public class Heroes
    {
        public static Hero CreateHydraOperative()
        {
            return new Hero
            {
                ID = "HydraOperative",
                PrintedRecruitPoints = 1,
                PrintedTeams = new List<string> { "HYDRA" },
                HeroName = "Ally",
                Title = "HYDRA Operative"
            };
        }

        public static Hero CreateHydraSoldier()
        {
            return new Hero
            {
                ID = "HydraSoldier",
                PrintedAttackPoints = 1,
                PrintedTeams = new List<string> { "HYDRA" },
                HeroName = "Ally",
                Title = "HYDRA Soldier"
            };
        }

        public static Hero CreateMadameHydra()
        {
            return new Hero
            {
                ID = "MadameHydra",
                AdditionalActions = new Dictionary<string, Action<Hero, GameEngine, Player>>
                {
                    {"Dodge", Keywords.Dodge}
                },
                PlayCondition = MadameHydraPlayCondition,
                PrintedCost = 3,
                PrintedRecruitPoints = 2,
                PrintedTeams = new List<string> { "HYDRA" },
                RulesText = "<b>Dodge</b>\r\n" +
                "To play this card, you must discard a card from your hand.",
                HeroName = "Viper",
                Title = "Madame HYDRA"

            };
        }

        public static Hero CreateNewRecruits()
        {
            return new Hero
            {
                ID = "NewRecruits",
                Play = NewRecruitsPlay,
                PrintedCost = 2,
                PrintedAttackPoints = 1,
                RulesText = "Return this card to the New Recruits Stack. Draw a Card. <i>(You still get this New Recruit's ATTACK.)</i>",
                HeroName = "Ally",
                Title = "New Recruits"
            };
        }

        private static bool MadameHydraPlayCondition(Hero card, GameEngine game, Player player)
        {
            // Force a discard
            throw new NotImplementedException();
        }

        private static void NewRecruitsPlay(Hero card, GameEngine game, Player player)
        {
            Hero.DefaultPlay(card, game, player);
            player.PlayedCards.Remove(card);
            game.Board.StandardHeroStacks["New Recruits"].Add(card);
            player.Draw();
        }
    }
}
