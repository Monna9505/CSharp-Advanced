using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "IDK";
            myCar.Model = "HRV Honda";
            myCar.Year = 2020;

            Console.WriteLine($"Make: {myCar.Make}, Model: {myCar.Model}, Year: {myCar.Year}");
        }
    }
}
