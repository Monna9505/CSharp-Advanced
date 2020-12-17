using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbersLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(integers);
            int[] evenNumbers = queue.Where(n => n % 2 == 0).ToArray();
            Console.WriteLine(string.Join(", ",evenNumbers));
        }
    }
}
