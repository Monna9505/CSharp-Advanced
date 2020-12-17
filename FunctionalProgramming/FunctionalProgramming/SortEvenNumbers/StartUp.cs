using System;
using System.Linq;

namespace SortEvenNumbers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var sorted = Sort(arr);
            Console.WriteLine(string.Join(", ",sorted));

        }

        private static int[] Sort(int[] arr)
        {
            return arr.Where(n => n % 2 == 0).OrderBy(m => m).ToArray();
        }
    }
}
