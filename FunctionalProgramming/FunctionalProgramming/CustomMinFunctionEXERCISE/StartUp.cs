using System;
using System.Linq;

namespace CustomMinFunctionEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Func<int[], int> smallestInt = ints =>
             {
                 int min = ints.Min();
                 return min;
             };

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestSmall = smallestInt(numbers);
            Console.WriteLine(bestSmall);
        }
    }
}
