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
            Queue<int> myQueue = new Queue<int>();

            //Enqueue
            for (int i = 0; i < NSX[0]; i++)
            {
                myQueue.Enqueue(myNumbers[i]);
            }

            //Pop
            for (int i = 0; i < NSX[1]; i++)
            {
                myQueue.Dequeue();
            }

            if (myQueue.Contains(NSX[2]))
            {
                Console.WriteLine("true");
            }
            else if (myQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(myQueue.Min());
            }
        }
    }
}
