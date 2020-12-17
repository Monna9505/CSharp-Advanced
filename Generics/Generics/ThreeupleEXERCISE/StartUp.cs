using System;

namespace ThreeupleEXERCISE
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split();
            Tuple<string, string, string> nameAddressTown =
                new Tuple<string, string, string>(input1[0] + " " + input1[1], input1[2], input1[3]);

            input1 = Console.ReadLine().Split();
            Tuple<string, int, bool> nameBeerDrunk =
                new Tuple<string, int, bool>(input1[0], int.Parse(input1[1]), input1[2] == "drunk" ? true : false);

            input1 = Console.ReadLine().Split();
            Tuple<string, double, string> nameAccBalanceBank =
                new Tuple<string, double, string>(input1[0], double.Parse(input1[1]), input1[2]);

            Console.WriteLine(nameAddressTown.ToString());
            Console.WriteLine(nameBeerDrunk.ToString());
            Console.WriteLine(nameAccBalanceBank.ToString());
        }
    }
}
