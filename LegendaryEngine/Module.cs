using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LegendaryEngine.Cards;

namespace LegendaryEngine
{
    public class Module
    {
        public string Name { get; set; }
        public List<ICard> StartingCards { get; set; }
        public Dictionary<string, List<BadCard>> BadCards { get; set; }
        public List<Bystander> Bystanders { get; set; }
        public Dictionary<string, List<Hero>> StandardHeroes { get; set; }

        public static Module Merge(List<Module> modules)
        {
            // For simplicity
            if (modules.Count == 1)
            {
                return modules[0];
            }

            Module mergedModules = new Module
            {
                BadCards = MergeStacks(modules.Select(module => module.BadCards).ToList()),
                Bystanders = MergeStack(modules.Select(module => module.Bystanders).ToList()),
                StandardHeroes = MergeStacks(modules.Select(module => module.StandardHeroes).ToList())
            };

            return mergedModules;
        }

        private static Dictionary<string, List<T>> MergeStacks<T>(List<Dictionary<string, List<T>>> allCards)
        {
            // Create a merged dictionary to populate
            Dictionary<string, List<T>> mergedCards = new Dictionary<string, List<T>>();

            // Iterate through the card types
            foreach (string type in allCards.SelectMany(stacks => stacks.Keys.ToList()).Distinct().ToList())
            {
                // Add this type to merged dictionary
                mergedCards[type] = new List<T>();

                // Iterate through the different modules' cards, appending the lists to the merged dictionary
                foreach (Dictionary<string, List<T>> cards in allCards)
                {
                    if (cards.ContainsKey(type))
                    {
                        mergedCards[type].AddRange(cards[type]);
                    }
                }
            }

            return mergedCards;
        }

        private static List<T> MergeStack<T>(List<List<T>> allCards)
        {
            return allCards.SelectMany(cards => cards).ToList();
        }
    }
}
