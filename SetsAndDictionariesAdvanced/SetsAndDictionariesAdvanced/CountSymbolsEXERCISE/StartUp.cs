using System;
using System.Collections.Generic;

namespace CountSymbolsEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();
            var dictOfChars = new SortedDictionary<char, int>();

            for (int i = 0; i < myString.Length; i++)
            {
                if (!dictOfChars.ContainsKey(myString[i]))
                {
                    dictOfChars.Add(myString[i], 1);
                }
                else
                {
                    dictOfChars[myString[i]]++;
                }
            }

            foreach (var character in dictOfChars)
            {
                Console.WriteLine($"{character.Key}: {character.Value} time/s");
            }
        }
    }
}
