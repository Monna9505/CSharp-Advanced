using System;
using System.Linq;

namespace SumMatrixElementsLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] myMatrix = new int[rowCol[0], rowCol[1]];

            for (int row = 0; row < myMatrix.GetLength(0); row++)
            {
                int[] integers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < integers.Length; col++)
                {
                    myMatrix[row, col] = integers[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < myMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < myMatrix.GetLength(1); col++)
                {
                    sum += myMatrix[row, col];
                }
            }

            Console.WriteLine(rowCol[0]);
            Console.WriteLine(rowCol[1]);
            Console.WriteLine(sum);
        }
    }
}
