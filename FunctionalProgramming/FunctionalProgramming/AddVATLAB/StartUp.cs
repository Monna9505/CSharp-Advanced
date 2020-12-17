using System;
using System.Linq;

namespace AddVATLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Func<double, double> addVAT = n => n += n * 0.20;
            Console.ReadLine().Split(", ").Select(double.Parse).Select(addVAT)
                .ToList().ForEach(n => Console.WriteLine($"{n:f2}"));
        }
    }
}
