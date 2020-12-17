using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTableEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> uniqueItems = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string[] items = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < items.Length; j++)
                {
                    uniqueItems.Add(items[j]);
                }
            }

            Console.WriteLine(string.Join(" ",uniqueItems.OrderBy(n => n)));
        }
    }
}
