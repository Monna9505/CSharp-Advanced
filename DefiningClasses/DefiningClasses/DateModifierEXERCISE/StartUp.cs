using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier d1 = new DateModifier();
            int diff = d1.DifferenceBetweenTwoDates(date1, date2);

            Console.WriteLine(diff);
        }
    }
}
