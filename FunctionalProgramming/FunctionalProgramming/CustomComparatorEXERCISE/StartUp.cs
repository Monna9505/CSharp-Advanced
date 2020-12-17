using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparatorEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int,bool> evenNumbers = n => n % 2 == 0;
            Func<int,bool> oddNumbers = n => n % 2 != 0;

            int[] even = arr.Where(evenNumbers).OrderBy(n => n).ToArray();
            int[] odd = arr.Where(oddNumbers).OrderBy(n => n).ToArray();

            List<int> final = new List<int>();
            final.AddRange(even);
            final.AddRange(odd);

            Console.WriteLine(string.Join(" ",final));
        }
    }
}
