using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTourEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> petrolDistance = new Queue<string>();

            for (int i = 0; i < n; i++)
            {
                string amountOfPetrolDistanceBetween = Console.ReadLine();
                amountOfPetrolDistanceBetween += $" {i}";
                petrolDistance.Enqueue(amountOfPetrolDistanceBetween);
            }

            int totalFuel = 0;

            for (int i = 0; i < n; i++)
            {
                string pD = petrolDistance.Dequeue();
                int[] petDist = pD.Split().Select(int.Parse).ToArray();
                int petrol = petDist[0];
                int distance = petDist[1];
                totalFuel += petrol;

                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    i = -1;
                    totalFuel = 0;
                }
                petrolDistance.Enqueue(pD);
            }

            var index = petrolDistance.Dequeue().Split().Select(int.Parse).ToArray();
            Console.WriteLine(index[2]);
        }
    }
}
