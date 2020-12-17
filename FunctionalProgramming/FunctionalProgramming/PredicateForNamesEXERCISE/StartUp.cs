using System;
using System.Linq;

namespace PredicateForNamesEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split().ToArray();
            names = names.Where(n => n.Length <= nameLength).ToArray();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
