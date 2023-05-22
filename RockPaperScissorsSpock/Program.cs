using System;

namespace RockPaperScissors
{
    class Program
    {
        private const int Rock = 0;
        private const int Paper = 1;
        private const int Scissors = 2;
        
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();

            string playerChoice;
            int playerValue = -1;

            int computerValue = randomNumbers.Next(5);
            string computerChoice;

            Console.Clear();
            Console.Write("Please enter rock, paper, scissors, lizard, or Spock ");
            playerChoice = Console.ReadLine().ToLower();

            if (playerChoice.Equals("rock"))
            {
                playerValue = Rock;
            }
            else if (playerChoice.Equals("paper"))
            {
                playerValue = Paper;
            }
            else if (playerChoice.Equals("scissors"))
            {
                playerValue = Scissors;
            }
            else
            {
                Console.WriteLine($"{playerChoice} is not a valid choice.");
            }

            if (computerValue == Rock))
            {
                computerChoice = "rock";
            }
            else if (computerValue == Paper)
            {
                computerChoice = "paper";
            }
            else
            {
                computerChoice = "scissors";
            }

            Console.WriteLine($"Computer chose {computerChoice} and player chose {playerChoice}.");
            Console.WriteLine($"Comparing {computerChoice} and {playerChoice}.");

            if (playerValue == computerValue)
            {
                Console.WriteLine("It's a draw.");
            }
            else if ((playerValue - 1 == computerValue) || (playerValue == Rock && computerValue == Scissors))
            {
                Console.WriteLine("Player wins!");
            }
            else
            {
                Console.WriteLine("Bummer - the machines win again.");
            }
        }
    }
}