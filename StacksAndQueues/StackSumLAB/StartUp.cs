using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSumLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(arrayOfInts);
            string command = string.Empty;

            while ((command = Console.ReadLine().ToLower()) != "end"
                || stack.Count == 0)
            {
                var theCommands = command.Split().ToArray();

                if (theCommands[0] == "add")
                {
                    stack.Push(int.Parse(theCommands[1]));
                    stack.Push(int.Parse(theCommands[2]));
                }
                else if (theCommands[0] == "remove"
                    && stack.Count >= int.Parse(theCommands[1]))
                {
                    for (int i = 0; i < int.Parse(theCommands[1]); i++)
                    {
                        stack.Pop();
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
