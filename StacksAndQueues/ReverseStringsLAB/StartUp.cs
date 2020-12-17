using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseStringsLAB
{
    class StartUp
    {
        static void Main(string[] args)
        { 
            string input = Console.ReadLine();
            Stack<char> myStack = new Stack<char>();

            foreach (var letter in input.ToCharArray())
            {
                myStack.Push(letter);
            }

            foreach (var letter in myStack)
            {
                Console.Write(letter);
            }
        }
    }
}
