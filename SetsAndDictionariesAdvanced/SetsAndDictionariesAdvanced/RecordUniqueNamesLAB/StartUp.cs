using System;
using System.Collections.Generic;

namespace RecordUniqueNamesLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int names = int.Parse(Console.ReadLine());
            HashSet<string> hashsetOfNames = new HashSet<string>();

            for (int i = 0; i < names; i++)
            {
                string name = Console.ReadLine();
                hashsetOfNames.Add(name);
            }

            foreach (var name in hashsetOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
