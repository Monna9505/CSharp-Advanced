using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArrayLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> myDict = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!myDict.ContainsKey(numbers[i]))
                {
                    myDict.Add(numbers[i], 1);
                }
                else
                {
                    myDict[numbers[i]]++;
                }
            }

            foreach (var number in myDict)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
