using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public class Board
    {
        public Mastermind Mastermind { get; set; }
        public Scheme Scheme { get; set; }
        public HQ HQState { get; set; }
        public City CityState { get; set; }
        public List<Card> HeroDeck { get; set; }
        public List<Card> VillainDeck { get; set; }
        public Dictionary<string, List<Card>> BadCardStacks { get; set; }
        public List<Card> BystanderStack { get; set; }
        public Dictionary<string, List<Card>> StandardHeroStacks { get; set; }
        public List<Card> MastermindTactics { get; set; }
        public List<Card> KOPile { get; set; }
        public List<Card> EscapePile { get; set; }


        public Board()
        {
            HQState = new HQ();
            CityState = new City();
            HeroDeck = new List<Card>();
            VillainDeck = new List<Card>();
            BadCardStacks = new Dictionary<string, List<Card>>();
            StandardHeroStacks = new Dictionary<string, List<Card>>();
            BystanderStack = new List<Card>();
            MastermindTactics = new List<Card>();
            KOPile = new List<Card>();
            EscapePile = new List<Card>();
        }

        public void Clear()
        {
            HQState.Clear();
            CityState.Clear();
            HeroDeck.Clear();
            VillainDeck.Clear();
            BystanderStack.Clear();
            MastermindTactics.Clear();
            KOPile.Clear();
            EscapePile.Clear();
        }

        public class HQ
        {
            public Card[] Cards { get; }

            internal HQ()
            {
                Cards = new Card[5];
            }

            internal void Clear()
            {
                throw new NotImplementedException();
            }
        }

        public class City
        {
            public Card[] Cards { get; }

            internal City()
            {
                Cards = new Card[5];
            }

            internal void Clear()
            {
                throw new NotImplementedException();
            }
        }
    }
}
