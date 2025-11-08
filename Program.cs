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

            Console.WriteLine("UC6: Report the number of times the dice was played and position after each roll\n");

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
            int diceCount = 0;
            Random random = new Random();

            Console.WriteLine($"Starting position: {playerPosition}\n");

            // Step 3: Game loop
            while (playerPosition != 100)
            {
                int diceRoll = random.Next(1, 7); // 1–6
                diceCount++;

                int option = random.Next(0, 3);   // 0 = No Play, 1 = Ladder, 2 = Snake

                Console.WriteLine($"Roll {diceCount}: Dice = {diceRoll}");

                switch (option)
                {
                    case 0: // No Play
                        Console.WriteLine("Option: No Play → Player stays in the same position.");
                        break;

                    case 1: // Ladder
                        if (playerPosition + diceRoll <= 100)
                        {
                            playerPosition += diceRoll;
                            Console.WriteLine($"Option: Ladder! Player climbs ahead by {diceRoll}");
                        }
                        else
                        {
                            Console.WriteLine($"Option: Ladder! But move skipped (need exact number to reach 100).");
                        }
                        break;

                    case 2: // Snake
                        playerPosition -= diceRoll;
                        if (playerPosition < 0)
                            playerPosition = 0;
                        Console.WriteLine($"Option: Snake! Player slides down by {diceRoll}");
                        break;
                }

                Console.WriteLine($"Current Position: {playerPosition}");
                Console.WriteLine("--------------------------------------");
            }

            // Step 4: Display results
            Console.WriteLine($"\n Total dice rolls to win: {diceCount}");
            Console.WriteLine(" Player reached EXACTLY 100 and WON the game!");
            Console.WriteLine("===============================================");
            Console.ReadKey();
        }
    }
}
