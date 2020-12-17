using System;
using System.Linq;

namespace SumMatrixColumnsLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] myMatrix = new int[rowCol[0], rowCol[1]];

            for (int row = 0; row < myMatrix.GetLength(0); row++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < array.Length; col++)
                {
                    myMatrix[row, col] = array[col];
                }
            }

            for (int col = 0; col < myMatrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < myMatrix.GetLength(0); row++)
                {
                    sum += myMatrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
