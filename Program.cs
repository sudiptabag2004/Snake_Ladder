using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("     Welcome to Snake and Ladder!     ");
            Console.WriteLine("======================================\n");

            Console.WriteLine("UC1: Game played with single player at start position 0\n");

            // Initialize player position
            int playerPosition = 0;

            // Display starting position
            Console.WriteLine($"Player starts the game at position: {playerPosition}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}