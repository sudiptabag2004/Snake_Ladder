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

            Console.WriteLine("UC3: Player checks for Option (No Play, Ladder, Snake)\n");

            // Step 1: Create 10x10 Board
            int[,] board = new int[10, 10];
            int num = 100;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board[i, j] = num--;
                }
            }

            // Step 2: Initialize player
            int playerPosition = 0;
            Console.WriteLine($"Player starts at position: {playerPosition}\n");

            // Step 3: Create random generator
            Random random = new Random();

            // Step 4: Roll die
            int diceRoll = random.Next(1, 7); // 1 to 6
            Console.WriteLine($"Dice rolled: {diceRoll}");

            // Step 5: Determine option (0: No Play, 1: Ladder, 2: Snake)
            int option = random.Next(0, 3);

            switch (option)
            {
                case 0: // No Play
                    Console.WriteLine("Option: No Play — Player stays in the same position.");
                    break;

                case 1: // Ladder
                    playerPosition += diceRoll;
                    Console.WriteLine($"Option: Ladder! Player climbs ahead by {diceRoll} → New Position: {playerPosition}");
                    break;

                case 2: // Snake
                    playerPosition -= diceRoll;
                    if (playerPosition < 0)
                        playerPosition = 0;
                    Console.WriteLine($"Option: Snake! Player slides down by {diceRoll} → New Position: {playerPosition}");
                    break;
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
