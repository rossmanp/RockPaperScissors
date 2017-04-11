using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    enum Roshambo
    {
        Rock,
        Paper,
        Scissors,
        Error
    };

    class Program
    {
        static void Main(string[] args)
        {
            int humanWins = 0;
            int computerWins = 0;
            bool run = true;
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();                      
            Player computerPlayer = RoshamboApp.GetComputerPlayer();
            while (run)
            {
                int winner = 0;
                winner = RoshamboApp.DetermineWinner(computerPlayer, name);
                if (winner == 1)
                {
                    humanWins++;
                }
                if (winner == -1)
                {
                    computerWins++;
                }                
                run = Continue(humanWins, computerWins);
            }
                      
        }

        public static Boolean Continue(int humanWins, int computerWins)
        {
            Console.Write("\nPlay again? (Y/N): ");
            string input = Console.ReadLine();
            Boolean run = true;
            input = input.ToLower();
            if (input == "n")
            {
                Console.WriteLine("You won " + humanWins + " times and the computer won " + computerWins + " times.");
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
              Console.WriteLine("I'm sorry, I didn't understand your input. Let's try that again!");
              run = Continue(humanWins, computerWins);
            }

            return run;
        }

    }
}
