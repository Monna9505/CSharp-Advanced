using System;
using System.Linq;

namespace JaggedArrayManipulatorEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArr = new double[rows][];

            //Filling the matrix
            for (int i = 0; i < rows; i++)
            {
                double[] rowArr = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jaggedArr[i] = rowArr;
            }

            //Analyzing the matrix
            for (int row = 0; row < rows-1; row++)
            {
                if (jaggedArr[row].Length == jaggedArr[row+1].Length)
                {
                    jaggedArr[row] = jaggedArr[row].Select(n => n * 2).ToArray();
                    jaggedArr[row + 1] = jaggedArr[row + 1].Select(n => n * 2).ToArray();
                }
                else
                {
                    jaggedArr[row] = jaggedArr[row].Select(n => n / 2).ToArray();
                    jaggedArr[row + 1] = jaggedArr[row + 1].Select(n => n / 2).ToArray();
                }
            }

            //Modifying the matrix
            string info = string.Empty;
            while ((info = Console.ReadLine()) != "End")
            {
                var splitedInfo = info.Split().ToArray();
                string command = splitedInfo[0];
                long row = long.Parse(splitedInfo[1]);
                long col = long.Parse(splitedInfo[2]);
                int value = int.Parse(splitedInfo[3]);

                if (command == "Add" && row >= 0 && row < rows &&
                    col >= 0 && col < jaggedArr[row].Length)
                {
                    jaggedArr[row][col] += value;
                }
                else if(command == "Subtract" && row >= 0 && row < rows &&
                    col >= 0 && col < jaggedArr[row].Length)
                {
                    jaggedArr[row][col] -= value;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ",jaggedArr[i]));
            }
        }
    }
}
