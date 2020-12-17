using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLotLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string info = "";
            HashSet<string> carNumbers = new HashSet<string>();

            while ((info = Console.ReadLine()) != "END")
            {
                string[] splitted = info.Split(", ").ToArray();
                string inOrOut = splitted[0];
                string carNumber = splitted[1];

                if (inOrOut == "IN")
                {
                    carNumbers.Add(carNumber);
                }
                else if(inOrOut == "OUT" && carNumbers.Contains(carNumber))
                {
                    carNumbers.Remove(carNumber);
                }
            }

            if (carNumbers.Count > 0)
            {
                foreach (var number in carNumbers)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
