using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public static class Utilities
    {
        private static readonly Random random = new Random();

        // @TODO: improve
        public static void Shuffle(this IList<Card> list)
        {
            int count = list.Count;
            while (count > 1)
            {
                count--;
                int k = random.Next(count + 1);
                Card card = list[k];
                list[k] = list[count];
                list[count] = card;
            }
        }

        public static Card Draw(this IList<Card> deck)
        {
            Card card = deck[0];
            deck.RemoveAt(0);
            return card;
        }

        // @TODO: improve
        public static List<Card> Draw(this IList<Card> deck, int numCards)
        {
            List<Card> cards = new List<Card>();

            for (int i = 0; i < numCards; i++)
            {
                cards.Add(deck.Draw());
            }

            return cards;
        }
    }
}
