using System;
using System.Linq;

namespace SumNumbersLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int count = arr.Count();
            int sum = arr.Sum();
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
