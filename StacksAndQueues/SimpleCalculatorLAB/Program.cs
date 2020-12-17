using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculatorLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expression = Console.ReadLine()
                .Split().Reverse().ToArray();
            Stack<string> myStack = new Stack<string>(expression);

            while (myStack.Count > 1)
            {
                int num = int.Parse(myStack.Pop());
                string sign = myStack.Pop();
                if (sign == "+")
                {
                    myStack.Push((num + int.Parse(myStack.Pop())).ToString());
                }
                else if (sign == "-")
                {
                    myStack.Push((num - int.Parse(myStack.Pop())).ToString());
                }
            }

            Console.WriteLine(myStack.Pop());
        }
    }
}
