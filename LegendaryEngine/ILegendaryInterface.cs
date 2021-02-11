using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public interface ILegendaryInterface
    {
        List<(Module module, string hero)> SelectHeroes(List<Module> modules, int? numHeroes, string prompt = "Select Heroes:");
        List<(Module module, string villain)> SelectVillains(List<Module> modules, int? numVillains, string prompt = "Select Villains:");
        List<(Module module, string henchman)> SelectHenchmanVillains(List<Module> modules, int? numVillains, string prompt = "Select Henchman Villains:");
        Module SelectModule(List<Module> x, string title = "Legendary Module Select", string prompt = "Select a module:");
    }
}
