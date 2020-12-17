using System;
using System.Linq;

namespace _2X2SquaresInMatrixEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[][] myMatrix = new char[rowsCols[0]][];

            for (int i = 0; i < rowsCols[0]; i++)
            {
                char[] charArr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                myMatrix[i] = charArr;
            }

            int count = 0;
            for (int row = 0; row < rowsCols[0]-1; row++)
            {
                for (int col = 0; col < rowsCols[1]-1; col++)
                {
                    if (myMatrix[row][col] == myMatrix[row][col+1] &&
                        myMatrix[row][col] == myMatrix[row+1][col] &&
                        myMatrix[row][col] == myMatrix[row+1][col+1])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
