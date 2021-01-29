using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LegendaryEngine
{
    public class Module
    {
        public Dictionary<string, List<IBadCard>> BadCards { get; set; }
        public List<IBystander> Bystanders { get; set; }

        public static Module Merge(List<Module> modules)
        {
            // For simplicity
            if (modules.Count == 1)
            {
                return modules[0];
            }

            Module mergedModules = new Module
            {
                BadCards = MergeBadCards(modules.Select(m => m.BadCards).ToList()),
                Bystanders = MergeBystanders(modules.Select(m => m.Bystanders).ToList())
            };

            return mergedModules;
        }

        private static Dictionary<string, List<IBadCard>> MergeBadCards(List<Dictionary<string, List<IBadCard>>> allBadCards)
        {
            // Create a merged dictionary to populate
            Dictionary<string, List<IBadCard>> mergedBadCards = new Dictionary<string, List<IBadCard>>();

            // Iterate through the bad card types
            foreach (string type in allBadCards.SelectMany(d => d.Keys.ToList()).Distinct().ToList())
            {
                // Add this type to merged dictionary
                mergedBadCards[type] = new List<IBadCard>();

                // Iterate through the different modules' bad cards, appending the lists to the merged dictionary
                foreach (Dictionary<string, List<IBadCard>> badCards in allBadCards)
                {
                    if (badCards.ContainsKey(type))
                    {
                        mergedBadCards[type].AddRange(badCards[type]);
                    }
                }
            }

            return mergedBadCards;
        }

        private static List<IBystander> MergeBystanders(List<List<IBystander>> allBystanders)
        {
            return allBystanders.SelectMany(b => b).ToList();
        }
    }
}
