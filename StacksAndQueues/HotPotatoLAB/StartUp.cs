using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotatoLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split().ToArray();
            int tossNumber = int.Parse(Console.ReadLine());
            Queue<string> queueKids = new Queue<string>(kids);

            while (queueKids.Count > 1)
            {
                for (int i = 1; i < tossNumber; i++)
                {
                    queueKids.Enqueue(queueKids.Dequeue());
                }
                Console.WriteLine($"Removed {queueKids.Dequeue()}");
            }

            Console.WriteLine($"Last is {queueKids.Dequeue()}");
        }
    }
}
