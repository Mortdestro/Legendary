using LegendaryEngine;
using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryHeroes
{
    public static class Schemes
    {
        public static Scheme CreateUnleashThePowerOfTheCosmicCube()
        {
            return new Scheme
            {
                ID = "UnleashThePowerOfTheCosmicCube",
                EvilWinCondition = UnleashThePowerOfTheCosmicCubeEvilWinCondition,
                RulesText = "<b>Setup</b>: 8 Twists.\r\n" +
                "<b>Twist</b>: Put the Twist next to this Scheme.\r\n" +
                "<b>Twists 5-6</b>: Each player gains a Wound.\r\n" +
                "<b>Twist 7</b>: Each player gains 3 Wounds.\r\n" +
                "<b>Twist 8</b>: Evil Wins!",
                // @TODO: Twist,
                Title = "Unleash The Power Of The Cosmic Cube",
                Twists = 8,
            };
        }

        #region Private Methods
        private static bool UnleashThePowerOfTheCosmicCubeEvilWinCondition(GameEngine game) => game.Twists >= 8;
        #endregion
    }
}
