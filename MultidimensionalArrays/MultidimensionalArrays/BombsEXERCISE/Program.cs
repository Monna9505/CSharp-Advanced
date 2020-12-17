using System;
using System.Linq;

namespace Bombs
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());
            int[][] myMatrix = new int[dimension][];

            for (int i = 0; i < dimension; i++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
                myMatrix[i] = array;
            }

            string[] bombCells = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < bombCells.Length; i++)
            {
                string[] myCells = bombCells[i].Split(",").ToArray();
                int row = int.Parse(myCells[0]);
                int col = int.Parse(myCells[1]);
                int currentBomb = myMatrix[row][col];
                if (currentBomb > 0)
                {
                    IsItGonnaExplode(myMatrix, row, col, currentBomb);
                }
            }

            int sum = 0;
            int countActiveCells = 0;
            foreach (var array in myMatrix)
            {
                sum += array.Where(n => n != 0 && n > 0).Sum();
                countActiveCells += array.Where(n => n != 0 && n > 0).Count();
            }

            Console.WriteLine($"Alive cells: {countActiveCells}");
            Console.WriteLine($"Sum: {sum}");

            foreach (var array in myMatrix)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }

        private static void IsItGonnaExplode(int[][] myMatrix, int row, int col, int currentBomb)
        {
            try
            {
                if (myMatrix[row][col - 1] > 0)
                {
                    myMatrix[row][col - 1] -= currentBomb;
                }
            }
            catch (Exception)
            {
            }

            try
            {
                if (myMatrix[row - 1][col] > 0)
                {
                    myMatrix[row - 1][col] -= currentBomb;
                }
            }
            catch (Exception)
            {
            }

            try
            {
                if (myMatrix[row][col + 1] > 0)
                {
                    myMatrix[row][col + 1] -= currentBomb;
                }
            }
            catch (Exception)
            {
            }

            try
            {
                if (myMatrix[row + 1][col] > 0)
                {
                    myMatrix[row + 1][col] -= currentBomb;
                }
            }
            catch (Exception)
            {
            }

            try
            {
                if (myMatrix[row - 1][col - 1] > 0)
                {
                    myMatrix[row - 1][col - 1] -= currentBomb;
                }
            }
            catch (Exception)
            {
            }

            try
            {
                if (myMatrix[row - 1][col + 1] > 0)
                {
                    myMatrix[row - 1][col + 1] -= currentBomb;
                }
            }
            catch (Exception)
            {
            }

            try
            {
                if (myMatrix[row + 1][col - 1] > 0)
                {
                    myMatrix[row + 1][col - 1] -= currentBomb;
                }
            }
            catch (Exception)
            {
            }

            try
            {
                if (myMatrix[row + 1][col + 1] > 0)
                {
                    myMatrix[row + 1][col + 1] -= currentBomb;
                }
            }
            catch (Exception)
            {
            }
            myMatrix[row][col] = 0;
        }
    }
}
