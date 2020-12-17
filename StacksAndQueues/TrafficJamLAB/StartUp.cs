using System;
using System.Collections.Generic;

namespace TrafficJamLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int carsPassGreenLight = int.Parse(Console.ReadLine());
            string car = Console.ReadLine();
            Queue<string> carsQueue = new Queue<string>();
            int numberOfCarsPassed = 0;

            while (car != "end")
            {
                if (car == "green")
                {
                    for (int i = 0; i < carsPassGreenLight; i++)
                    {
                        if (carsQueue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        numberOfCarsPassed++;
                    }
                }
                else
                {
                    carsQueue.Enqueue(car);
                }

                car = Console.ReadLine();
            }

            Console.WriteLine($"{numberOfCarsPassed} cars passed the crossroads.");
        }
    }
}
