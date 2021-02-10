using LegendaryEngine.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public interface ILegendaryInterface
    {
        List<(Module module, string hero)> SelectHeroes(List<Module> modules, int? numHeroes, string title = "Hero Select", string prompt = "Select Heroes:");
        Module SelectModule(List<Module> x, string title = "Legendary Module Select", string prompt = "Select a module:");
    }
}
