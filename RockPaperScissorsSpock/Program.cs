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

            do
            {
                int computerValue = randomNumbers.Next(3);
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
            while (GetYesOrNo("Would you like to play again?"));
        }

        /**
        * Returns a boolean response to a yes/no question.
        *
        * @param string
        *            The question to be asked.
        * @return True if the answer was yes, False if no.
        */
        public static bool GetYesOrNo(string question)
        {
            char answer;
            while (true)  // infinite loop.  return will exit the method, thus terminating the loop
            {
                Console.Write($"{question} ");
                answer = Console.ReadKey(true).KeyChar;
                answer = char.ToLower(answer);
                if (answer.Equals('y'))
                    return true;
                if (answer.Equals('n'))
                    return false;
            }
        }
    }
}