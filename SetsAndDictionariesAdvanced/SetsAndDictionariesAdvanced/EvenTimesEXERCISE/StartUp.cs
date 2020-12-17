using System;
using System.Linq;

namespace EvenTimesEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }

            var num = arr.GroupBy(n => n).Where(m => m.Count() % 2 == 0).Select(k => k.Key).First();
            Console.WriteLine(num);
        }
    }
}
