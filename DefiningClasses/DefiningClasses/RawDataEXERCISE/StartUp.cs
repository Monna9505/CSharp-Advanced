using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string info = Console.ReadLine();
            Car[] cars = new Car[n];
            int i = 0;

            while (info != "fragile" && info != "flamable")
            {
                string[] infoSplitted = info.Split().ToArray();

                string model = infoSplitted[0];
                int engineSpeed = int.Parse(infoSplitted[1]);
                int enginePower = int.Parse(infoSplitted[2]);
                int weight = int.Parse(infoSplitted[3]);
                string cargoType = infoSplitted[4];
                double tirePressure1 = double.Parse(infoSplitted[5]);
                int tireAge1 = int.Parse(infoSplitted[6]);
                double tirePressure2 = double.Parse(infoSplitted[7]);
                int tireAge2 = int.Parse(infoSplitted[8]);
                double tirePressure3 = double.Parse(infoSplitted[9]);
                int tireAge3 = int.Parse(infoSplitted[10]);
                double tirePressure4 = double.Parse(infoSplitted[11]);
                int tireAge4 = int.Parse(infoSplitted[12]);

                Tire[] tires = new Tire[4]
                {
                    new Tire(tirePressure1,tireAge1),
                    new Tire(tirePressure2,tireAge2),
                    new Tire(tirePressure3,tireAge3),
                    new Tire(tirePressure4,tireAge4)
                };
                Engine engine = new Engine(engineSpeed,enginePower);
                Cargo cargo = new Cargo(weight,cargoType);

                Car car = new Car(model, engine, cargo, tires);
                cars[i] = car;
                i++;
                info = Console.ReadLine();
            }

            if (info == "fragile")
            {
                var fragileCars = cars.Where(n => n.Cargo.Type == "fragile" && n.Tires.Any(m => m.Pressure < 1));
                foreach (var car in fragileCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                var flamableCars = cars.Where(n => n.Cargo.Type == "flamable" && n.Engine.EnginePower > 250);
                foreach (var car in flamableCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
