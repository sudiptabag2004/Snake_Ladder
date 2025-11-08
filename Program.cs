using System;
using System.Collections.Generic;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");
            Console.WriteLine("UC1: Game played with single player at start position 0");

            // Create a 10x10 board using a 2D array
            int[,] board = new int[10, 10];
            
            // Initialize board with numbers (1 to 100)
            int num = 100;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board[i, j] = num--;
                }
            }

            // Display board (optional visualization)
            Console.WriteLine("\nBoard Layout:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(board[i, j].ToString("D2") + "\t");
                }
                Console.WriteLine();
            }

            // Single player starting position
            int playerPosition = 0;
            Console.WriteLine($"\nPlayer starts at position: {playerPosition}");

            Console.ReadKey();
        }
    }
}