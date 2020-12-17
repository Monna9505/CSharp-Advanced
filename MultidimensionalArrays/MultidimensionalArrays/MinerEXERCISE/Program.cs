using System;
using System.Linq;

namespace Miner
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            var commands = Console.ReadLine().Split();
            string[][] myJagged = new string[fieldSize][];
            int row = 0;
            int col = 0;
            int coal = 0;

            FillMatrix(myJagged, ref row, ref col, fieldSize);
            int initialRow = 0;
            int initialCol = 0;

            for (int i = 0; i < commands.Length; i++)
            {
                initialRow = row;
                initialCol = col;

                switch (commands[i])
                {
                    case "up":
                        row--;
                        break;
                    case "down":
                        row++;
                        break;
                    case "right":
                        col++;
                        break;
                    case "left":
                        col--;
                        break;
                    default:
                        break;
                }

                var insideOrNo = IsInside(ref row, ref col, myJagged);
                if (insideOrNo)
                {
                    if (myJagged[row][col] == "c")
                    {
                        myJagged[row][col] = "*";
                    }
                    else if (myJagged[row][col] == "e")
                    {
                        Console.WriteLine($"Game over! ({row}, {col})");
                        return;
                    }
                }
                else
                {
                    row = initialRow;
                    col = initialCol;
                }
            }

            int coalLeft = CoalLeft(myJagged);
            if (coalLeft == 0)
            {
                Console.WriteLine($"You collected all coals! ({row}, {col})");
            }
            else
            {
                Console.WriteLine($"{coalLeft} coals left. ({row}, {col})");
            }
        }

        private static int CoalLeft(string[][] myJagged)
        {
            int count = 0;
            foreach (var item in myJagged)
            {
                foreach (var shit in item)
                {
                    if (shit == "c")
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private static int AnyCoal(string[][] myJagged)
        {
            int count = 0;
            foreach (var item in myJagged)
            {
                foreach (var shit in item)
                {
                    if (shit == "c")
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private static bool IsInside(ref int row, ref int col, string[][] myJagged)
        {
            if ((row >= 0 && row <= myJagged.GetLength(0) - 1) && (col >= 0 && col <= myJagged.GetLength(0) - 1))
            {
                return true;
            }
            return false;
        }

        private static void FillMatrix(string[][] myJagged, ref int row, ref int col, int fieldSize)
        {
            for (int i = 0; i < fieldSize; i++)
            {
                var array = Console.ReadLine().Split().ToList();
                myJagged[i] = array.ToArray();

                if (array.Contains("s"))
                {
                    row = i;
                    col = array.IndexOf("s");
                }
            }
        }
    }
}
