using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendaryEngine
{
    public class GameEngine
    {
        public List<Module> Modules { get; }
        public List<Player> Players { get; }
        public Turn CurrentTurn { get; }
        public Board Board { get; }

        private readonly ILegendaryInterface ui;

        private GameEngine()
        {
            Players = new List<Player>();
            Board = new Board();
        }

        public GameEngine(int numPlayers, List<Module> modules, ILegendaryInterface ui) : this()
        {
            Modules = modules;
            this.ui = ui;

            for (int i = 0; i < numPlayers; i++)
            {
                Players.Add(new Player
                {
                    Name = $"Player {i + 1}",
                    Deck = new List<Card>(),
                    DiscardPile = new List<Card>(),
                    Hand = new List<Card>(),
                    PlayedCards = new List<Card>(),
                    VictoryPile = new List<Card>()
                });
            }
        }

        public void Start()
        {
            PopulateStacks();
            PopulatePlayerDecks();
            PopulateHeroes();
        }

        private void PopulateStacks()
        {
            Module module = Module.Merge(Modules);

            PopulateBadCardStacks(module);
            PopulateBystanderStack(module);
            PopulateStandardHeroStacks(module);
        }

        private void PopulateBadCardStacks(Module module)
        {
            if (module.BadCards == null) return;

            foreach (string type in module.BadCards.Keys)
            {
                Board.BadCardStacks[type] = new List<Card>(module.BadCards[type]);
                Board.BadCardStacks[type].Shuffle();
            }
        }

        private void PopulateBystanderStack(Module module)
        {
            Board.BystanderStack = new List<Card>(module.Bystanders);
            Board.BystanderStack.Shuffle();
        }

        private void PopulateStandardHeroStacks(Module module)
        {
            if (module.StandardHeroes == null) return;

            foreach (string type in module.StandardHeroes.Keys)
            {
                Board.StandardHeroStacks[type] = new List<Card>(module.StandardHeroes[type]);
                Board.StandardHeroStacks[type].Shuffle();
            }
        }

        private void PopulatePlayerDecks()
        {
            List<Module> baseModules = Modules.Where(m => m.StartingCards != null && m.StartingCards.Count > 0).ToList();

            if (baseModules.Count == 0)
            {
                throw new InvalidOperationException("No module with starting cards selected.");
            }

            Module module = baseModules.Count == 1 ?
                baseModules[0] :
                ui.SelectModule(baseModules, "Starting Player Decks", "Which starting player decks should be used?");

            foreach (Player player in Players)
            {
                player.Deck.AddRange(module.StartingCards);
                player.Deck.Shuffle();
            }
        }

        private void PopulateHeroes()
        {
            int numHeroes = Players.Count == 5 ? 6 : 5;
            List<(Module module, string hero)> heroes = ui.SelectHeroes(Modules, numHeroes);
            foreach ((Module module, string hero) in heroes)
            {
                Board.HeroDeck.AddRange(module.Heroes[hero]);
            }
            Board.HeroDeck.Shuffle();
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
