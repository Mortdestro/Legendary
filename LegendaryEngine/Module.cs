using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LegendaryEngine
{
    public class Module
    {
        public Dictionary<string, List<BadCard>> BadCards { get; set; }
        public List<Bystander> Bystanders { get; set; }

        public static Module Merge(List<Module> modules)
        {
            // For simplicity
            if (modules.Count == 1)
            {
                return modules[0];
            }

            Module mergedModules = new Module
            {
                BadCards = MergeBadCards(modules.Select(ic => ic.BadCards).ToList())
            };

            return mergedModules;
        }

        private static Dictionary<string, List<BadCard>> MergeBadCards(List<Dictionary<string, List<BadCard>>> allBadCards)
        {
            // Create a merged dictionary to populate
            Dictionary<string, List<BadCard>> mergedBadCards = new Dictionary<string, List<BadCard>>();
            // Iterate through the bad card types
            foreach (string type in allBadCards.SelectMany(d => d.Keys.ToList()).Distinct().ToList())
            {
                // Add this type to merged dictionary
                mergedBadCards[type] = new List<BadCard>();

                // Iterate through the different modules' bad cards, appending the lists to the merged dictionary
                foreach (Dictionary<string, List<BadCard>> badCards in allBadCards)
                {
                    if (badCards.ContainsKey(type))
                    {
                        mergedBadCards[type].AddRange(badCards[type]);
                    }
                }
            }

            return mergedBadCards;
        }
    }
}
