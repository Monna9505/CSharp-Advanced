using System;
using System.Linq;

namespace PrimaryDiagonalLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] myMatrix = new int[size, size];

            for (int row = 0; row < myMatrix.GetLength(0); row++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < array.Length; col++)
                {
                    myMatrix[row, col] = array[col];
                }
            }

            int sumDiagonal = 0;
            int i = 0;
            for (int row = 0; row < myMatrix.GetLength(0); row++)
            {
                sumDiagonal += myMatrix[row, i];
                i++;
            }

            Console.WriteLine(sumDiagonal);
        }
    }
}
