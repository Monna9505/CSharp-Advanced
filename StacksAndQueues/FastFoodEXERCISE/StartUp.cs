using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFoodEXERCISE
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] foodOrders = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            Queue<int> queueOfFood = new Queue<int>(foodOrders);
            int sum = 0;

            Console.WriteLine(queueOfFood.Max());

            while (true)
            {
                int currentDish = queueOfFood.Peek();
                sum += currentDish;

                if (foodQuantity >= sum)
                {
                    queueOfFood.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queueOfFood)}");
                    break;
                }

                if (queueOfFood.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    break;
                }
            }
        }
    }
}
