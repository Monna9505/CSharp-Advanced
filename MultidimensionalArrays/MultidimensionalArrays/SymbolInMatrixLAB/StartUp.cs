using System;
using System.Linq;

namespace SymbolInMatrixLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string someString = Console.ReadLine();
                char[] charArray = someString.ToCharArray();
                for (int col = 0; col < charArray.Length; col++)
                {
                    matrix[row, col] = charArray[col].ToString();
                }
            }

            string theSymbol = Console.ReadLine();
            bool symbolExists = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == theSymbol)
                    {
                        symbolExists = true;
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{theSymbol} does not occur in the matrix");
        }
    }
}
