using System;

namespace Task4
{
    internal class Program
    {
        static void Main()
        {
            bool continuePlaying = true;

            while (continuePlaying)
            {
                Console.Write("Enter the minimum number : ");
                int minNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the maximum number : ");
                int maxNumber = Convert.ToInt32(Console.ReadLine());

                int randomNumber = GenerateRandomNumber(minNumber, maxNumber);
                int guessCount = 0;

                Console.WriteLine("I have generated a number between {0} and {1}.", minNumber, maxNumber);

                while (true)
                {
                    Console.Write("Guess the number: ");
                    int guess = Convert.ToInt32(Console.ReadLine());
                    guessCount++;

                    if (guess == randomNumber)
                    {
                        Console.WriteLine($"Congratulations! You guessed the number correctly in {guessCount} attempt(s).");
                        break;
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Incorrect. Try higher number.");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect. Try lower number.");
                    }
                }

                Console.Write("continue playing? (y/n): ");
                string playAgain = Console.ReadLine();

                if (playAgain.ToLower() != "y")
                {
                    continuePlaying = false;
                }
            }

            Console.WriteLine("Game Over!");
        }

        static int GenerateRandomNumber(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max + 1);
        }
    }
}
