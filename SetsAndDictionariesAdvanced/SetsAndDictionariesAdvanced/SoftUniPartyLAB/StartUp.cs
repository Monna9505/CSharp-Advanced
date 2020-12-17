using System;
using System.Collections.Generic;

namespace SoftUniPartyLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string guest = "";
            HashSet<string> guests = new HashSet<string>();

            while (true)
            {
                guest = Console.ReadLine();
                if (guest.Length == 8)
                {
                    guests.Add(guest);
                }

                if (guest == "PARTY")
                {
                    break;
                }
            }

            while ((guest = Console.ReadLine()) != "END")
            {
                guests.Remove(guest);
            }

            Console.WriteLine(guests.Count);

            foreach (var guest1 in guests)
            {
                if (char.IsDigit(guest1[0]))
                {
                    Console.WriteLine(guest1);
                }
            }
            foreach (var guest2 in guests)
            {
                if (char.IsLetter(guest2[0]))
                {
                    Console.WriteLine(guest2);
                }
            }
        }
    }
}
