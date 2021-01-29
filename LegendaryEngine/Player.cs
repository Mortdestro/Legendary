using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public class Player
    {
        public string Name;
        public List<ICard> Hand;
        public List<ICard> PlayedCards;
        public List<ICard> Deck;
        public List<ICard> DiscardPile;
        public List<ICard> VictoryPile;
    }
}
