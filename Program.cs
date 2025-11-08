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

            Console.WriteLine("UC7: Play the game with 2 players. Ladder gives an extra turn.\n");

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

            // Step 2: Initialize players
            int player1Position = 0;
            int player2Position = 0;
            int diceCount = 0;
            bool isPlayer1Turn = true;

            Random random = new Random();

            // Step 3: Game loop
            while (player1Position != 100 && player2Position != 100)
            {
                diceCount++;
                int diceRoll = random.Next(1, 7);
                int option = random.Next(0, 3); // 0: No Play, 1: Ladder, 2: Snake

                string currentPlayer = isPlayer1Turn ? "Player 1" : "Player 2";
                int currentPosition = isPlayer1Turn ? player1Position : player2Position;

                Console.WriteLine($"Roll {diceCount}: {currentPlayer} rolled {diceRoll}");

                switch (option)
                {
                    case 0: // No Play
                        Console.WriteLine($"{currentPlayer} → No Play (stays at {currentPosition})");
                        break;

                    case 1: // Ladder
                        if (currentPosition + diceRoll <= 100)
                        {
                            currentPosition += diceRoll;
                            Console.WriteLine($"{currentPlayer} → Ladder! Climbs ahead by {diceRoll} → Position: {currentPosition}");
                            // Ladder grants another turn (so don't switch turn)
                            if (isPlayer1Turn)
                                player1Position = currentPosition;
                            else
                                player2Position = currentPosition;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"{currentPlayer} → Ladder but move skipped (need exact number to reach 100)");
                        }
                        break;

                    case 2: // Snake
                        currentPosition -= diceRoll;
                        if (currentPosition < 0)
                            currentPosition = 0;
                        Console.WriteLine($"{currentPlayer} → Snake! Slides down by {diceRoll} → Position: {currentPosition}");
                        break;
                }

                // Update player positions
                if (isPlayer1Turn)
                    player1Position = currentPosition;
                else
                    player2Position = currentPosition;

                Console.WriteLine($"Player 1: {player1Position} | Player 2: {player2Position}");
                Console.WriteLine("--------------------------------------");

                // Switch turn
                isPlayer1Turn = !isPlayer1Turn;
            }

            // Step 4: Declare winner
            Console.WriteLine("\n======================================");
            if (player1Position == 100)
                Console.WriteLine($" Player 1 WON the game in {diceCount} rolls!");
            else
                Console.WriteLine($" Player 2 WON the game in {diceCount} rolls!");
            Console.WriteLine("======================================");

            Console.ReadKey();
        }
    }
}
