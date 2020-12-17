using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicatesEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine()
             .Split().Select(int.Parse).ToArray();

            Func<int, int[]> numbers = n =>
             {
                 int[] arr = new int[n];
                 int j = 0;
                 for (int i = 1; i <= n; i++)
                 {
                     arr[j] = i;
                     j++;
                 }
                 return arr;
             };
            Func<int, int, bool> isDivisible = (m, n) => m % n == 0;

            List<int> final = CheckIfDivisible(numbers(n), dividers, isDivisible);
            Console.WriteLine(string.Join(" ",final));
        }

        static List<int> CheckIfDivisible(int[] arr,int[] dividers,Func<int,int,bool> isDivisible)
        {
            List<int> final = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int putInside = 0;
                for (int j = 0; j < dividers.Length; j++)
                {
                    if (isDivisible(arr[i],dividers[j]))
                    {
                        continue;
                    }
                    putInside = 1;
                }
                if (putInside == 0)
                {
                    final.Add(arr[i]);
                }
            }

            return final;
        }
    }
}
