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

            Console.WriteLine("UC4: Repeat till the Player reaches the winning position 100\n");

            // Step 1: Create 10x10 board
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
            Random random = new Random();

            Console.WriteLine($"Starting position: {playerPosition}\n");

            // Step 3: Game loop
            while (playerPosition < 100)
            {
                int diceRoll = random.Next(1, 7); // 1 to 6
                int option = random.Next(0, 3);   // 0 = No Play, 1 = Ladder, 2 = Snake

                switch (option)
                {
                    case 0: // No Play
                        Console.WriteLine($"No Play. Player stays at position {playerPosition}");
                        break;

                    case 1: // Ladder
                        playerPosition += diceRoll;
                        Console.WriteLine($"Ladder! Player climbs ahead by {diceRoll} → Position: {playerPosition}");
                        break;

                    case 2: // Snake
                        playerPosition -= diceRoll;
                        if (playerPosition < 0)
                            playerPosition = 0;
                        Console.WriteLine($"Snake! Player slides down by {diceRoll} → Position: {playerPosition}");
                        break;
                }

                Console.WriteLine("--------------------------------------");
            }

            // Step 4: Player wins
            Console.WriteLine("\n Player reached 100 and won the game!");
            Console.WriteLine("======================================");
            Console.ReadKey();
        }
    }
}
