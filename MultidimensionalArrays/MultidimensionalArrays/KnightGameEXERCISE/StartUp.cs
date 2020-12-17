using System;

namespace KnightGameEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            PopulateMatrix(matrix, size);

            int bestAttacks = int.MaxValue;


            while (true)
            {
                int attacks = 0;
                for (int row = 0; row < matrix.GetLength(0) - 2; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            attacks = Attacks(matrix, row, col, size);
                        }
                        if (bestAttacks < attacks)
                        {
                            bestAttacks = attacks;
                        }
                    }
                }
                if (attacks == 0)
                {
                    break;
                }
            }

            Console.WriteLine(bestAttacks);
        }

        private static int Attacks(char[,] matrix,int row,int col,int size)
        {
            int attacks = 0;
            if (AreValid(row - 2, col + 1, size) && matrix[row - 2, col + 1] == 'K')
            {
                attacks++;
            }
            if (AreValid(col + 2, row - 1, size) && matrix[row - 1, col + 2] == 'K')
            {
                attacks++;
            }
            if (AreValid(col + 1, row + 2, size) && matrix[row + 2, col + 1] == 'K')
            {
                attacks++;
            }
            if (AreValid(col - 2, row - 1, size) && matrix[row - 1, col - 2] == 'K')
            {
                attacks++;
            }
            if (AreValid(col - 1, row - 2, size) && matrix[row - 2, col - 1] == 'K')
            {
                attacks++;
            }
            if (AreValid(row + 2, col - 1, size) && matrix[row + 2, col - 1] == 'K')
            {
                attacks++;
            }
            if (AreValid(row + 1, col - 2, size) && matrix[row + 1, col - 2] == 'K')
            {
                attacks++;
            }
            if (AreValid(row + 1, col + 2, size) && matrix[row + 1, col + 2] == 'K')
            {
                attacks++;
            }

            return attacks;
        }
        private static bool AreValid(int row, int col, int size)
        {
            return row >= 0 && row < size
                && col >= 0 && col < size;
        }

        private static void PopulateMatrix(char[,] matrix, int size)
        {
            for (int row = 0; row < size; row++)
            {
                string theString = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = theString[col];
                }
            }
        }
    }
}
