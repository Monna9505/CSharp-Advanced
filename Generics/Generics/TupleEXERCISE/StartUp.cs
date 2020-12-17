using System;
using System.Linq;

namespace TupleEXERCISE
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split();
            Tuple<string, string> nameAddressTuple = new Tuple<string, string>(input1[0] + " " + input1[1], input1[2]);

            var input2 = Console.ReadLine().Split();
            Tuple<string, int> nameBeerTuple = new Tuple<string, int>(input2[0], int.Parse(input2[1]));

            var input3 = Console.ReadLine().Split();
            Tuple<int,double> intDoubleTuple = new Tuple<int, double>(int.Parse(input3[0]), double.Parse(input3[1]));

            Console.WriteLine(nameAddressTuple.ToString());
            Console.WriteLine(nameBeerTuple.ToString());
            Console.WriteLine(intDoubleTuple.ToString());
        }
    }
}
