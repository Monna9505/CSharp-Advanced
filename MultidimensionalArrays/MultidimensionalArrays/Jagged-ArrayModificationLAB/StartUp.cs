using System;
using System.Linq;

namespace Jagged_ArrayModificationLAB
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] myJaggedArray = new int[size][];

            for (int i = 0; i < size; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                myJaggedArray[i] = arr;
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] someInfo = command.Split().ToArray();
                string com = someInfo[0];
                int row = int.Parse(someInfo[1]);
                int col = int.Parse(someInfo[2]);
                int value = int.Parse(someInfo[3]);

                if (row < 0 || row >= size ||
                    col < 0 || col >= myJaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    if (com == "Add")
                    {
                        myJaggedArray[row][col] += value;
                    }
                    else if (com == "Subtract")
                    {
                        myJaggedArray[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < myJaggedArray.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ",myJaggedArray[i]));
            }
        }
    }
}
