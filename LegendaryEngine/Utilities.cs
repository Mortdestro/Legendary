using System;
using System.Collections.Generic;
using System.Text;

namespace LegendaryEngine
{
    public static class Utilities
    {
        private static readonly Random random = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int count = list.Count;
            while (count > 1)
            {
                count--;
                int k = random.Next(count + 1);
                T value = list[k];
                list[k] = list[count];
                list[count] = value;
            }
        }
    }
}
