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

            Console.WriteLine("UC2: Player rolls the die to get a number between 1 and 6\n");

            // Player starts at position 0
            int playerPosition = 0;

            // Create Random object for dice roll
            Random random = new Random();

            // Roll the die
            int diceRoll = random.Next(1, 7); // generates number between 1 and 6 (inclusive)

            // Display results
            Console.WriteLine($"Player starts at position: {playerPosition}");
            Console.WriteLine($"Player rolled the die and got: {diceRoll}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}