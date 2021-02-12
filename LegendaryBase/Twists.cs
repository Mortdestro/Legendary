using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryHeroes
{
    public static class Twists
    {
        public static Twist CreateSchemeTwist()
        {
            return new Twist
            {
                ID = "SchemeTwist",
                Title = "Scheme Twist"
            };
        }
    }
}
