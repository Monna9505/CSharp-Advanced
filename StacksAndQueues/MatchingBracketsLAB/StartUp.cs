using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchingBrackets
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> myStack = new Stack<int>();
            int start = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    myStack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    start = myStack.Pop();
                    string subExp = expression.Substring(start, (i - start) + 1);
                    Console.WriteLine(subExp);
                }
            }
        }
    }
}
