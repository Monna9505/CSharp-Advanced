using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStringsEXERCISE
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                Box<string> box = new Box<string>(name);
                boxes.Add(box);
            }

            int[] indexes = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            Swap(boxes, indexes[0], indexes[1]);

            foreach (var box in boxes)
            {
                Console.WriteLine(box.ToString());
            }
        }

        private static void Swap<T>(List<Box<T>> boxes, int index1, int index2)
        {
            Box<T> box = boxes[index1];
            boxes[index1] = boxes[index2];
            boxes[index2] = box;
        }
    }
}
