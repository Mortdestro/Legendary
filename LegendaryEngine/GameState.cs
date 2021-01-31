using LegendaryEngine.CardInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendaryEngine
{
    public class GameState
    {
        public List<Player> Players { get; set; }
        public IMastermind Mastermind { get; set; }
        public IScheme Scheme { get; set; }
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

            Players = new List<Player>();
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

            for (int i = 0; i < numPlayers; i++)
            {
                Players.Add(new Player
                {
                    Name = $"Player {i + 1}",
                    Deck = new List<ICard>(),
                    DiscardPile = new List<ICard>(),
                    Hand = new List<ICard>(),
                    PlayedCards = new List<ICard>(),
                    VictoryPile = new List<ICard>()
                });
            }
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

        public void PopulateStacks(List<Module> modules, SelectModule selectModule)
        {
            Module module = Module.Merge(modules);

            PopulateBadCardStacks(module);
            PopulateBystanderStack(module);
            PopulateStandardHeroStacks(module);
            PopulatePlayerDecks(modules, selectModule);
        }

        private void PopulateBadCardStacks(Module module)
        {
            if (module.BadCards == null) return;

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

        private void PopulateStandardHeroStacks(Module module)
        {
            if (module.StandardHeroes == null) return;

            foreach (string type in module.StandardHeroes.Keys)
            {
                StandardHeroStacks[type] = new List<ICard>(module.StandardHeroes[type]);
                StandardHeroStacks[type].Shuffle();
            }
        }

        public delegate Module SelectModule(List<Module> x, string prompt = "");

        public void PopulatePlayerDecks(List<Module> modules, SelectModule selectModule)
        {
            List<Module> baseModules = modules.Where(m => m.StartingCards != null && m.StartingCards.Count > 0).ToList();
            Module module = selectModule(baseModules, "Which starting decks should be used?");

            foreach (Player player in Players)
            {
                player.Deck.AddRange(module.StartingCards);
                player.Deck.Shuffle();
            }
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
