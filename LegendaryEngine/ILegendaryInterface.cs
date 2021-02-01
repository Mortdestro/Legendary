using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public interface ILegendaryInterface
    {
        Module SelectModule(List<Module> x, string title = "Legendary Module Select", string prompt = "Select a module:");
    }
}
