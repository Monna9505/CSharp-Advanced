using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElementEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stackOfNumbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] commandElements = Console.ReadLine()
                .Split().Select(int.Parse).ToArray();

                switch (commandElements[0])
                {
                    case 1:
                        stackOfNumbers.Push(commandElements[1]);
                        break;
                    case 2:
                        if (stackOfNumbers.Count > 0)
                        {
                            stackOfNumbers.Pop();
                        }
                        break;
                    case 3:
                        if (stackOfNumbers.Count > 0)
                        {
                            Console.WriteLine(stackOfNumbers.Max());
                        }
                        break;
                    case 4:
                        if (stackOfNumbers.Count > 0)
                        {
                            Console.WriteLine(stackOfNumbers.Min());
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ",stackOfNumbers));
        }
    }
}
