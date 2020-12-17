using System;
using System.Linq;

namespace SquareWithMaximumSumLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < array.Length; col++)
                {
                    matrix[row, col] = array[col];
                }
            }

            int bestSum = 0;
            int[,] bestMatrix = new int[2, 2];

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                int sum = 0;
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    sum += matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestMatrix[0, 0] = matrix[row, col];
                        bestMatrix[0, 1] = matrix[row, col + 1];
                        bestMatrix[1, 0] = matrix[row + 1, col];
                        bestMatrix[1, 1] = matrix[row + 1, col + 1];
                    }
                    sum = 0;
                }
            }

            Console.WriteLine(bestMatrix[0, 0] + " " + bestMatrix[0, 1]);
            Console.WriteLine(bestMatrix[1, 0] + " " + bestMatrix[1, 1]);
            Console.WriteLine(bestSum);
        }
    }
}
