using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public class Player
    {
        public string Name;
        public List<Card> Hand;
        public List<Card> PlayedCards;
        public List<Card> Deck;
        public List<Card> DiscardPile;
        public List<Card> VictoryPile;

        public void Draw(int numCards = 1)
        {
            throw new NotImplementedException();
        }
    }
}
