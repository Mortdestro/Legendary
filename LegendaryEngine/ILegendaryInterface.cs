using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public interface ILegendaryInterface
    {
        Scheme SelectScheme(List<Module> modules, string prompt = "Select a Scheme:");
        List<(Module module, string villain)> SelectVillains(List<Module> modules, int? numVillains, string prompt = "Select Villains:");
        List<(Module module, string henchman)> SelectHenchmanVillains(List<Module> modules, int? numVillains, string prompt = "Select Henchman Villains:");
        List<(Module module, string hero)> SelectHeroes(List<Module> modules, int? numHeroes, string prompt = "Select Heroes:");
        Module SelectModule(List<Module> x, string prompt = "Select a module:");
    }
}
