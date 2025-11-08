using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("        Snake and Ladder Game         ");
            Console.WriteLine("======================================\n");

            Console.WriteLine("UC2: Player rolls the die (1–6) using Random\n");

            // Step 1: Create a 10x10 board
            int[,] board = new int[10, 10];
            int num = 100;

            // Fill the board with numbers from 100 to 1
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board[i, j] = num--;
                }
            }

            // Step 2: Show the board (optional, for visualization)
            Console.WriteLine("Board Layout:\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(board[i, j].ToString("D2") + "\t");
                }
                Console.WriteLine();
            }

            // Step 3: Initialize player position
            int playerPosition = 0;
            Console.WriteLine($"\nPlayer starts at position: {playerPosition}");

            // Step 4: Roll the die
            Random random = new Random();
            int diceRoll = random.Next(1, 7); // 1 to 6 inclusive
            Console.WriteLine($"Player rolled the die and got: {diceRoll}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}