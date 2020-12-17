using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string tireInfo = "";
            List<Tire[]> listTires = new List<Tire[]>();
            List<Engine> listEngines = new List<Engine>();
            List<Car> listCars = new List<Car>();

            while ((tireInfo = Console.ReadLine()) != "No more tires")
            {
                string[] splitted = tireInfo.Split().ToArray();
                int year1 = int.Parse(splitted[0]);
                double pressure1 = double.Parse(splitted[1]);
                int year2 = int.Parse(splitted[2]);
                double pressure2 = double.Parse(splitted[3]);
                int year3 = int.Parse(splitted[4]);
                double pressure3 = double.Parse(splitted[5]);
                int year4 = int.Parse(splitted[6]);
                double pressure4 = double.Parse(splitted[7]);

                Tire[] tire = 
                { 
                    new Tire(year1,pressure1),
                    new Tire(year2,pressure2),
                    new Tire(year3,pressure3),
                    new Tire(year4,pressure4)
                };

                listTires.Add(tire);
            }

            string engineInfo = "";
            while ((engineInfo = Console.ReadLine()) != "Engines done")
            {
                string[] splitted = engineInfo.Split().ToArray();
                int horsePower = int.Parse(splitted[0]);
                double cubicCaapacity = double.Parse(splitted[1]);

                Engine engine = new Engine(horsePower, cubicCaapacity);

                listEngines.Add(engine);
            }

            string carInfo = "";
            while ((carInfo = Console.ReadLine()) != "Show special")
            {
                string[] splitted = carInfo.Split().ToArray();
                string make = splitted[0];
                string model = splitted[1];
                int year = int.Parse(splitted[2]);
                double fuelQuantity = double.Parse(splitted[3]);
                double fuelConsumption = double.Parse(splitted[4]);
                int engineIndex = int.Parse(splitted[5]);
                int tiresIndex = int.Parse(splitted[6]);

                Car car = new Car(make,model,year,
                    fuelQuantity,fuelConsumption,
                    listEngines[engineIndex],
                    listTires[tiresIndex]);

                listCars.Add(car);
            }

            foreach (var car in listCars)
            {
                double sumTirePressure = 0;

                for (int i = 0; i < car.Tires.Length; i++)
                {
                    sumTirePressure += car.Tires[i].Pressure;
                }

                if (car.Year >= 2017 && 
                    car.Engine.HorsePower > 330 &&
                    (sumTirePressure >= 9 && sumTirePressure <= 10))
                {
                    car.Drive(20);
                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}
