using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public class GameState
    {
        public Player[] Players { get; set; }
        public Mastermind Mastermind { get; set; }
        public Scheme Scheme { get; set; }
        public Turn CurrentTurn { get; set; }
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

        public GameState(int numPlayers)
        {

            Players = new Player[numPlayers];
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

        /*
        public void Reset()
        {
            HeroDeck.Clear();
            VillainDeck.Clear();
            BadCardStack.Clear();
            BystanderStack.Clear();
            MastermindTactics.Clear();
            KOPile.Clear();
            EscapePile.Clear();
        }
        */

        public void PopulateStacks(List<Module> modules)
        {
            Module module = Module.Merge(modules);

            PopulateBadCardStacks(module);
            PopulateBystanderStack(module);
        }

        private void PopulateBadCardStacks(Module module)
        {
            foreach (string type in module.BadCards.Keys)
            {
                BadCardStacks[type] = new List<ICard>(module.BadCards[type]);
                BadCardStacks[type].Shuffle();
            }
        }

        private void PopulateBystanderStack(Module module)
        {
                BystanderStack = new List<ICard>(module.Bystanders);
                BystanderStack.Shuffle();
        }

        public class HQ
        {
            public ICard[] Cards { get; }

            public HQ()
            {
                Cards = new ICard[5];
            }
        }

        public class City
        {
            public ICard[] Cards { get; }

            public City()
            {
                Cards = new ICard[5];
            }

        }

        public class Turn
        {
            public Player Player { get; set; }
            public int RecruitPoints { get; set; }
            public int AttackPoints { get; set; }
            public Dictionary<string, int> ClassesPlayed { get; set; }
            public Dictionary<string, int> TeamsPlayed { get; set; }
        }
    }
}
