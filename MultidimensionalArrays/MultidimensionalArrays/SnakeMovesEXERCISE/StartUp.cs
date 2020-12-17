using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeMovesEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            char[,] snakeMatrix = new char[dimensions[0], dimensions[1]];
            Queue<char> snakeQueue = new Queue<char>(snake.ToCharArray());

            for (int row = 0; row < dimensions[0]; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < dimensions[1]; col++)
                    {
                        DoTheMagic(snakeQueue, snakeMatrix, row, col);
                    }
                }
                else
                {
                    for (int col = dimensions[1] - 1; col >= 0; col--)
                    {
                        DoTheMagic(snakeQueue, snakeMatrix, row, col);
                    }
                }
            }

            for (int row = 0; row < dimensions[0]; row++)
            {
                for (int col = 0; col < dimensions[1]; col++)
                {
                    Console.Write(snakeMatrix[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static void DoTheMagic(Queue<char> snakeQueue, char[,] snakeMatrix,int row, int col)
        {
            char letter = snakeQueue.Dequeue();
            snakeMatrix[row, col] = letter;
            snakeQueue.Enqueue(letter);
        }
    }
}
