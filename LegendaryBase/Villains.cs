using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryHeroes
{
    public class Villains
    {
        #region HYDRA
        public static Villain CreateSupremeHydra()
        {
            return new Villain
            {
                ID = "SupremeHydra",
                PrintedAttackPoints = 6,
                PrintedVictoryPoints = 3,
                RulesText = "Supreme HYDRA is worth <b>+3 VICTORY</b> for each other HYDRA Villain in your Victory Pile.",
                Title = "Supreme HYDRA",
                // @TODO: VictoryPoints,
                VillainGroup = "HYDRA"
            };
        }

        public static Villain CreateViper()
        {
            return new Villain
            {
                ID = "Viper",
                // @TODO: Escape,
                // @TODO: Fight,
                PrintedAttackPoints = 5,
                PrintedVictoryPoints = 3,
                RulesText = "<b>Fight</b>: Each player without another HYDRA Villain in their Victory Pile gains a Wound.\r\n" +
                "<b>Escape</b>: Same effect.",
                Title = "Viper",
                VillainGroup = "HYDRA"
            };
        }

        public static Villain CreateEndlessArmiesOfHydra()
        {
            return new Villain
            {
                ID = "EndlessArmiesOfHydra",
                // @TODO: Fight,
                FlavorText = "\"Hail HYDRA! Immortal HYDRA! Cut off a limb, and two more shall take its place!\"",
                PrintedAttackPoints = 4,
                PrintedVictoryPoints = 3,
                RulesText = "<b>Fight</b>: Play the top two cards of the Villain Deck.",
                Title = "Endless Armies Of HYDRA",
                VillainGroup = "HYDRA"
            };
        }

        public static Villain CreateHydraKidnappers()
        {
            return new Villain
            {
                ID = "HydraKidnappers",
                // @TODO: Fight,
                PrintedAttackPoints = 3,
                PrintedVictoryPoints = 1,
                RulesText = "<b>Fight</b>: You may gain a S.H.I.E.L.D. Officer.",
                Title = "HYDRA Kidnappers",
                VillainGroup = "HYDRA"
            };
        }
        #endregion

        #region Spider-Foes
        public static Villain CreateGreenGoblin()
        {
            return new Villain
            {
                ID = "GreenGoblin",
                // @TODO: Ambush,
                PrintedAttackPoints = 6,
                PrintedVictoryPoints = 4,
                RulesText = "<b>Ambush</b>: Green Goblin captures a Bystander.",
                Title = "Green Goblin",
                VillainGroup = "Spider-Foes"
            };
        }

        public static Villain CreateVenom()
        {
            return new Villain
            {
                ID = "Venom",
                // @TODO: FightCondition,
                PrintedAttackPoints = 5,
                PrintedVictoryPoints = 3,
                RulesText = "You can't defeat Venom unless you have a COVERT Hero." +
                "<b>Escape</b>: Each player gains a Wound.",
                Title = "Venom",
                VillainGroup = "Spider-Foes"
            };
        }

        public static Villain CreateDoctorOctopus()
        {
            return new Villain
            {
                ID = "DoctorOctopus",
                // @TODO: Fight,
                PrintedAttackPoints = 4,
                PrintedVictoryPoints = 2,
                RulesText = "<b>Fight</b>: When you draw a new hand of cards at the end of this turn, draw eight cards instead of six.",
                Title = "Doctor Octopus",
                VillainGroup = "Spider-Foes"
            };
        }

        public static Villain CreateTheLizard()
        {
            return new Villain
            {
                ID = "TheLizard",
                // @TODO: Fight,
                PrintedAttackPoints = 3,
                PrintedVictoryPoints = 2,
                RulesText = "<b>Fight</b>: If you fight the Lizard in the Sewers, each other player gains a Wound.",
                Title = "The Lizard",
                VillainGroup = "Spider-Foes"
            };
        }
        #endregion

        #region Skrulls
        public static Villain CreateSkrullQueenVeranke()
        {
            return new Villain
            {
                ID = "SkrullQueenVeranke",
                // @TODO: Ambush,
                // @TODO: Fight,
                PrintedAttackPoints = 0,
                PrintedVictoryPoints = 4,
                RulesText = "<b>Ambush</b>: Put the highest-cost Hero from the HQ under this Villain. This Villain's ATTACK is equal to that Hero's COST.\r\n" +
                "<b>Fight</b>: Gain that Hero",
                Title = "Skrull Queen Veranke",
                VillainGroup = "Skrulls"
            };
        }

        public static Villain CreatePaibokThePowerSkrull()
        {
            return new Villain
            {
                ID = "PaibokThePowerSkrull",
                // @TODO: Fight,
                PrintedAttackPoints = 8,
                PrintedVictoryPoints = 3,
                RulesText = "<b>Fight</b>: Choose a Hero in the HQ for each player. Each player gains that Hero.",
                Title = "Paibok The Power Skrull",
                VillainGroup = "Skrulls"
            };
        }

        public static Villain CreateSuperSkrull()
        {
            return new Villain
            {
                ID = "SuperSkrull",
                // @TODO: Fight,
                PrintedAttackPoints = 4,
                PrintedVictoryPoints = 2,
                RulesText = "<b>Fight</b>: Each player KOs one of their Heroes.",
                Title = "Super-Skrull",
                VillainGroup = "Skrulls"
            };
        }

        public static Villain CreateSkrullShapeshifters()
        {
            return new Villain
            {
                ID = "SkrullShapeshifters",
                // @TODO: Ambush,
                // @TODO: Fight,
                PrintedAttackPoints = 0,
                PrintedVictoryPoints = 2,
                RulesText = "<b>Ambush</b>: Put the rightmost Hero from the HQ under this Villain. This Villain's ATTACK is equal to that Hero's COST.\r\n" +
                "<b>Fight</b>: Gain that Hero",
                Title = "Skrull Shapeshifters",
                VillainGroup = "Skrulls"
            };
        }
        #endregion

        #region Henchman Villains
        public static Villain CreateSentinel()
        {
            return new Villain
            {
                ID = "Sentinel",
                // @TODO: Fight,
                FlavorText = "\"MUTANT ENERGY SIGNATURE DETECTED.\"",
                Henchman = true,
                PrintedAttackPoints = 3,
                PrintedVictoryPoints = 1,
                RulesText = "<b>Fight</b>: KO one of your Heroes.",
                Title = "Sentinel",
                VillainGroup = "Sentinel"
            };
        }
        #endregion

        #region Private Methods

        #endregion
    }
}
