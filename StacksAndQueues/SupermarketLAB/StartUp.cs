using System;
using System.Collections.Generic;

namespace SupermarketLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> myQueue = new Queue<string>();

            while (name != "End")
            {
                if (name == "Paid")
                {
                    while (myQueue.Count > 0)
                    {
                        Console.WriteLine(myQueue.Dequeue());
                    }
                }
                else
                {
                    myQueue.Enqueue(name);
                }
                name = Console.ReadLine();
            }

            Console.WriteLine($"{myQueue.Count} people remaining.");
        }
    }
}
