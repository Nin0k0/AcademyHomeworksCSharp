using System;

namespace _1_HOMEWORK
{
    internal class Program
    {
        static void Main()
        {
            #region Task2
            Console.WriteLine("Choose temperature");

            string temp = Console.ReadLine();
            if (double.TryParse(temp, out _))
            {
                Console.WriteLine(Temperature(double.Parse(temp)));

            }
            else
            {
                Console.WriteLine("Not a Valid temperature");
            }

            static string Temperature(double temp)
            {
                double lowBarrier = 0;
                double highBarrier = 30;

                return temp > highBarrier ? "It's hot!" :
                       temp < lowBarrier ? "It's cold!" : "Nice Weather!";
            }

            #endregion

            #region TASK3

            var words = new string[] { "rock", "paper", "scissor" };
            Console.WriteLine("Choose rock, paper, or scissor :");
            var playerChoice = Console.ReadLine().ToLower().Trim();
            string GetRandomChoice()
            {
                var random = new Random();
                int index = random.Next(words.Length);
                return words[index];
            }

            if (playerChoice == "rock" || playerChoice == "paper" || playerChoice == "scissor")
            {
                string computerChoice = GetRandomChoice();

                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("Draw!");
                }
                else if ((playerChoice == "rock" && computerChoice == "scissor") ||
                             (playerChoice == "paper" && computerChoice == "rock") ||
                             (playerChoice == "scissor" && computerChoice == "paper"))
                {
                    Console.WriteLine($"Your Choice was: {playerChoice}\nComputer's Choice was: {computerChoice}\nYou win!");
                }
                else { Console.WriteLine($"Your Choice was: {playerChoice}\nComputer's Choice was: {computerChoice}\nYou lose!"); }


            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }

            #endregion

            Console.WriteLine("Enter your birth year:");
            var birthYearStr = Console.ReadLine();

            if (int.TryParse(birthYearStr, out _))
            {

                int birthYear = int.Parse(birthYearStr);
                int startYear = 1900;
                var animalsByYears = new string[] { "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };
                int indexOfResult = (birthYear - startYear) % animalsByYears.Length;

                if (indexOfResult < 0)
                {
                    indexOfResult += animalsByYears.Length;
                }

                Console.WriteLine($"You were born in {animalsByYears[indexOfResult]} year!");

            }
            else
            {
                Console.WriteLine("Invalid Year Expression!");
            }










        }
    }
}
