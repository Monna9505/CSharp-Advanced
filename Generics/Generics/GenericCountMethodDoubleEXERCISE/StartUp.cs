using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubleEXERCISE
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> elements = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double someString = double.Parse(Console.ReadLine());
                elements.Add(someString);
            }

            double elementToCompare = double.Parse(Console.ReadLine());
            int count = Compare(elements, elementToCompare);
            Console.WriteLine(count);
        }

        private static int Compare<T>(List<T> elements, T elementToCompare)
            where T : IComparable<T>
        {
            int count = 0;
            foreach (var element in elements)
            {
                if (element.CompareTo(elementToCompare) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
