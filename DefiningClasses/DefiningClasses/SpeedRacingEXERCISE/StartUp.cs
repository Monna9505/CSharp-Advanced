using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> listCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] car = Console.ReadLine().Split().ToArray();
                string model = car[0];
                double fuelAmount = double.Parse(car[1]);
                double fuelConsumptionForKm = double.Parse(car[2]);

                Car carCurrent = new Car(model, fuelAmount, fuelConsumptionForKm);

                if (!listCars.Contains(carCurrent))
                {
                    listCars.Add(carCurrent);
                }
            }

            string command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                string[] split = command.Split().ToArray();
                double amountKm = double.Parse(split[2]);

                var currentCar = listCars.FirstOrDefault(n => n.Model == split[1]);
                currentCar.Drive(amountKm);
            }

            foreach (var car in listCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
