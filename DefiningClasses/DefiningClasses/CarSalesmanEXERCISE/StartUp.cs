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
            List<Engine> listEngines = new List<Engine>();
            List<Car> listCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var engineInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                if (engineInfo.Length == 4)
                {
                    listEngines.Add(new Engine(model, power, int.Parse(engineInfo[2]), engineInfo[3]));
                }
                else if (engineInfo.Length == 3)
                {
                    int p = 0;
                    if (int.TryParse(engineInfo[2],out p))
                    {
                        int displacement = int.Parse(engineInfo[2]);
                        listEngines.Add(new Engine(model, power, displacement));
                        continue;
                    }
                    listEngines.Add(new Engine(model, power, engineInfo[2]));
                    continue;
                }
                listEngines.Add(new Engine(model, power));
            }

            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                var carInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = carInfo[0];
                var engine = listEngines.FirstOrDefault(n => n.Model == carInfo[1]);

                if (carInfo.Length == 4)
                {
                    listCars.Add(new Car(model,engine,int.Parse(carInfo[2]),carInfo[3]));
                }
                else if (carInfo.Length == 3)
                {
                    int p = 0;
                    if (int.TryParse(carInfo[2], out p))
                    {
                        listCars.Add(new Car(model, engine, int.Parse(carInfo[2])));
                        continue;
                    }
                    listCars.Add(new Car(model, engine, carInfo[2]));
                }
                else
                {
                    listCars.Add(new Car(model, engine));
                }
            }

            foreach (var car in listCars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
