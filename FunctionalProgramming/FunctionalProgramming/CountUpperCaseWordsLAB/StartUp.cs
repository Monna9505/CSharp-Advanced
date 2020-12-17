using System;
using System.Linq;

namespace CountUpperCaseWordsLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Func<string, bool> isUpper = n => char.IsUpper(n[0]);
            Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(isUpper).ToList()
                .ForEach(n => Console.WriteLine(n));
        }
    }
}
