using LegendaryEngine.CardInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public class Board
    {
        public IMastermind Mastermind { get; set; }
        public IScheme Scheme { get; set; }
        public HQ HQState { get; set; }
        public City CityState { get; set; }
        public List<ICard> HeroDeck { get; set; }
        public List<ICard> VillainDeck { get; set; }
        public Dictionary<string, List<ICard>> BadCardStacks { get; set; }
        public List<ICard> BystanderStack { get; set; }
        public Dictionary<string, List<ICard>> StandardHeroStacks { get; set; }
        public List<ICard> MastermindTactics { get; set; }
        public List<ICard> KOPile { get; set; }
        public List<ICard> EscapePile { get; set; }


        public Board()
        {
            HQState = new HQ();
            CityState = new City();
            HeroDeck = new List<ICard>();
            VillainDeck = new List<ICard>();
            BadCardStacks = new Dictionary<string, List<ICard>>();
            StandardHeroStacks = new Dictionary<string, List<ICard>>();
            BystanderStack = new List<ICard>();
            MastermindTactics = new List<ICard>();
            KOPile = new List<ICard>();
            EscapePile = new List<ICard>();
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
            public ICard[] Cards { get; }

            internal HQ()
            {
                Cards = new ICard[5];
            }

            internal void Clear()
            {
                throw new NotImplementedException();
            }
        }

        public class City
        {
            public ICard[] Cards { get; }

            internal City()
            {
                Cards = new ICard[5];
            }

            internal void Clear()
            {
                throw new NotImplementedException();
            }
        }
    }
}
