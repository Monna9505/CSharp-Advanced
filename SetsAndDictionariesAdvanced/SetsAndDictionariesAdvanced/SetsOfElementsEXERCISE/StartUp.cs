using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElementsEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            //First set
            for (int i = 0; i < nm[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }

            //Second set
            for (int i = 0; i < nm[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondSet.Add(num);
            }

            HashSet<int> intersected = new HashSet<int>(firstSet);
            intersected.IntersectWith(secondSet);

            Console.WriteLine(string.Join(" ",intersected));
        }
    }
}
