using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentAndCountryLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());
            var myDictionry = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < pairs; i++)
            {
                string[] continentsAndCountries = Console.ReadLine().Split().ToArray();
                string continent = continentsAndCountries[0];
                string country = continentsAndCountries[1];
                string city = continentsAndCountries[2];

                if (!myDictionry.ContainsKey(continent))
                {
                    myDictionry.Add(continent, new Dictionary<string, List<string>>());
                    myDictionry[continent].Add(country, new List<string>());
                    myDictionry[continent][country].Add(city);
                }
                else if (!myDictionry[continent].ContainsKey(country))
                {
                    myDictionry[continent].Add(country, new List<string>());
                    myDictionry[continent][country].Add(city);
                }
                else
                {
                    myDictionry[continent][country].Add(city);
                }
            }

            foreach (var continent in myDictionry)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in myDictionry[continent.Key])
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
