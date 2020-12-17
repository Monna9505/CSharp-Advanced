using System;
using System.Linq;

namespace MaximalSumEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] myMatrix = new int[rowsCols[0], rowsCols[1]];

            for (int row = 0; row < rowsCols[0]; row++)
            {
                int[] arr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < arr.Length; col++)
                {
                    myMatrix[row, col] = arr[col];
                }
            }

            int bestSum = 0;
            int[,] bestMatrix = new int[3, 3];
            for (int row = 0; row < myMatrix.GetLength(0)-2; row++)
            {
                int sum = 0;
                for (int col = 0; col < myMatrix.GetLength(1)-2; col++)
                {
                    sum = myMatrix[row, col] + myMatrix[row, col + 1] + myMatrix[row, col + 2]
                        + myMatrix[row + 1, col] + myMatrix[row + 1, col + 1] + myMatrix[row + 1, col + 2]
                        + myMatrix[row + 2, col] + myMatrix[row + 2, col + 1] + myMatrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestMatrix[0, 0] = myMatrix[row, col];
                        bestMatrix[0, 1] = myMatrix[row, col + 1];
                        bestMatrix[0, 2] = myMatrix[row, col + 2];
                        bestMatrix[1, 0] = myMatrix[row + 1, col];
                        bestMatrix[1, 1] = myMatrix[row + 1, col + 1];
                        bestMatrix[1, 2] = myMatrix[row + 1, col + 2];
                        bestMatrix[2, 0] = myMatrix[row + 2, col];
                        bestMatrix[2, 1] = myMatrix[row + 2, col + 1];
                        bestMatrix[2, 2] = myMatrix[row + 2, col + 2];
                    }
                }
            }

            Console.WriteLine($"Sum = {bestSum}");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(bestMatrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
