using System;
using System.Linq;

namespace DiagonalDifferenceEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] myJagged = new int[n][];
            int primarySum = 0;
            int secondarySum = 0;

            for (int row = 0; row < n; row++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                myJagged[row] = arr;
            }

            //Primary diagonal
            for (int row = 0; row < n; row++)
            {
                primarySum += myJagged[row][row];
            }

            //Secondary diagonal
            int len = n - 1;
            for (int i = 0; i < n; i++)
            {
                secondarySum += myJagged[i][len - i];
            }

            int diff = Math.Abs(primarySum - secondarySum);

            Console.WriteLine(diff);
        }
    }
}
