using System;
using System.Linq;

namespace ActionPointEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            Action<string> print = Print;

            print(names);
        }

        public static void Print(string names)
        {
            string[] myNames = names.Split().ToArray();

            foreach (var name in myNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
