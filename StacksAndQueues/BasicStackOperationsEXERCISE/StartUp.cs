using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperationsEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] NSX = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int[] myNumbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            Stack<int> myStack = new Stack<int>();

            //Push
            for (int i = 0; i < NSX[0]; i++)
            {
                myStack.Push(myNumbers[i]);
            }

            //Pop
            for (int i = 0; i < NSX[1]; i++)
            {
                myStack.Pop();
            }

            if (myStack.Contains(NSX[2]))
            {
                Console.WriteLine("true");
            }
            else if (myStack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(myStack.Min());
            }
        }
    }
}
