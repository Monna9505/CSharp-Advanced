using System;
using System.Linq;

namespace MatrixShufflingEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[rowCol[0], rowCol[1]];

            for (int row = 0; row < rowCol[0]; row++)
            {
                string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < arr.Length; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            string[] info = Console.ReadLine().Split().ToArray();
            while (info[0] != "END")
            {
                if (info[0] == "swap")
                {
                    if (info.Length == 5)
                    {
                        int row1 = int.Parse(info[1]);
                        int col1 = int.Parse(info[2]);
                        int row2 = int.Parse(info[3]);
                        int col2 = int.Parse(info[4]);

                        if ((row1 >= 0 && row1 <= rowCol[0] - 1) &&
                            (col1 >= 0 && col1 <= rowCol[1] - 1) &&
                            (row2 >= 0 && row2 <= rowCol[0] - 1) &&
                            (col2 >= 0 && col2 <= rowCol[1] - 1))
                        {
                            string swap = matrix[row1, col1];
                            matrix[row1, col1] = matrix[row2, col2];
                            matrix[row2, col2] = swap;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                            info = Console.ReadLine().Split().ToArray();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        info = Console.ReadLine().Split().ToArray();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    info = Console.ReadLine().Split().ToArray();
                    continue;
                }

                for (int row = 0; row < rowCol[0]; row++)
                {
                    for (int col = 0; col < rowCol[1]; col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }

                info = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
