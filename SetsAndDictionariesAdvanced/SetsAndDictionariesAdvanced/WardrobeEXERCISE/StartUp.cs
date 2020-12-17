using System;
using System.Collections.Generic;
using System.Linq;

namespace WardrobeEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var dictOfClothes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] clothingInfo = Console.ReadLine().Split(" -> ").ToArray();
                string color1 = clothingInfo[0];
                string[] clothes = clothingInfo[1].Split(",").ToArray();

                if (!dictOfClothes.ContainsKey(color1))
                {
                    dictOfClothes.Add(color1, new Dictionary<string, int>());

                    AddClothes(clothes, dictOfClothes, color1);
                }
                else
                {
                    AddClothes(clothes, dictOfClothes, color1);
                }
            }

            string[] clothLookingFor = Console.ReadLine().Split().ToArray();
            string color = clothLookingFor[0];
            string clothing = clothLookingFor[1];

            foreach (var cloth in dictOfClothes)
            {
                Console.WriteLine($"{cloth.Key} clothes:");
                var clothes = dictOfClothes[cloth.Key].ToArray();

                for (int i = 0; i < clothes.Length; i++)
                {
                    if (color == cloth.Key && clothes[i].Key == clothing)
                    {
                        Console.WriteLine($"* {clothes[i].Key} - {clothes[i].Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes[i].Key} - {clothes[i].Value}");
                    }
                }
            }
        }

        private static void AddClothes(string[] clothes, Dictionary<string, Dictionary<string, int>> dictOfClothes, string color)
        {
            for (int j = 0; j < clothes.Length; j++)
            {
                if (!dictOfClothes[color].ContainsKey(clothes[j]))
                {
                    dictOfClothes[color].Add(clothes[j], 1);
                }
                else
                {
                    dictOfClothes[color][clothes[j]]++;
                }
            }
        }
    }
}
