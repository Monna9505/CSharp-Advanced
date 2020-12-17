using System;
using System.Linq;

namespace KnightsOfHonorEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().ToArray();
            Action<string[]> sirNames = AddSir;

            AddSir(names);
        }

        static void AddSir(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = "Sir " + names[i];
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
