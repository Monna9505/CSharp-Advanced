using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOddsEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Predicate<int> predicate = n => n % 2 == 0;
            Func<int, int, List<int>> funcDelegate = (start, end) =>
            {
                List<int> numbers = new List<int>();
                for (int i = start; i <= end; i++)
                {
                    numbers.Add(i);
                }

                return numbers;
            };

            if (command == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            Console.WriteLine(string.Join(" ",Print(funcDelegate(bounds[0],bounds[1]),predicate)));
        }

        static List<int> Print(List<int> numbers, Predicate<int>EvenOrOdd)
        {
            List<int> final = new List<int>();
            foreach (var num in numbers)
            {
                if (EvenOrOdd(num))
                {
                    final.Add(num);
                }
            }

            return final;
        }
    }
}
