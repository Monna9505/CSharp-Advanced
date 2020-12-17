using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutiqueEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int capacityOfRack = int.Parse(Console.ReadLine());
            Stack<int> stackClothes = new Stack<int>(clothes);
            int racksNeeded = 0;

            while (stackClothes.Count > 0)
            {
                int sum = 0;
                int lastItem = 0;
                while (sum < capacityOfRack && stackClothes.Count != 0)
                {
                    lastItem = stackClothes.Pop();
                    sum += lastItem;
                }

                if (sum > capacityOfRack)
                {
                    stackClothes.Push(lastItem);
                }
                racksNeeded++;
            }

            Console.WriteLine(racksNeeded);
        }
    }
}
