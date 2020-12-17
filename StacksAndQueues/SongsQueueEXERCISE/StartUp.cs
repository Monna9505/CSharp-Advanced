using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueueEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            string[] commands = Console.ReadLine().Split("Add",StringSplitOptions.RemoveEmptyEntries).ToArray();
            Queue<string> queueOfSongs = new Queue<string>(songs);

            while (true)
            {
                switch (commands[0])
                {
                    case "Play":
                        queueOfSongs.Dequeue();
                    break;
                    case "Show":
                        Console.WriteLine(string.Join(", ",queueOfSongs));
                    break;
                    default:
                        if (queueOfSongs.Contains(commands[0].Trim()))
                        {
                            Console.WriteLine($"{commands[0].Trim()} is already contained!");
                        }
                        else
                        {
                            queueOfSongs.Enqueue(commands[0].Trim());
                        }
                        break;
                }

                if (queueOfSongs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    return;
                }

                commands = Console.ReadLine().Split("Add",StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }
    }
}
