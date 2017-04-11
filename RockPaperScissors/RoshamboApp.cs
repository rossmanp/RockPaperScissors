using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RoshamboApp
    {
        //GetComputerPlayer takes either B or L as input and outputs Bart or Lisa to the 
        //computerPlayer variable.

        public static Player GetComputerPlayer()
        {
            bool run = true;
            string input = "";
            while (run)
            {
                Console.WriteLine("Would you like to play against Bart or Lisa? (B/L)");
                input = Console.ReadLine();
                input = input.ToUpper();
                if (input.Equals("B") || input.Equals("L"))
                {
                    run = false;
                }
                else
                {
                    Console.WriteLine("You did not input B or L. Please try again.");
                }
            }
            if (input.Equals("B"))
            {
                Bart Simpson = new Bart();
                return Simpson;
            }
            else 
            {
                Lisa Simpson = new Lisa();
                return Simpson;
            }            
        }

        //Determine Winner calls Roshambo values for each player, compares them,
        //and then returns an integer dependent on the result of the game.

        public static int DetermineWinner(Player computerPlayer, string name)
        {
            User human = new User();
            Roshambo userRoshambo = human.generateRoshambo();
            Roshambo computerRoshambo = computerPlayer.generateRoshambo();
            Console.WriteLine("\n" + name + ": " + userRoshambo);
            Console.WriteLine(computerPlayer.name + ": " + computerRoshambo);

            if (userRoshambo == computerRoshambo)
            {
                Console.WriteLine("Draw!");
                return 0;
            }
            else if (userRoshambo == Roshambo.Rock && computerRoshambo == Roshambo.Scissors ||
                userRoshambo == Roshambo.Scissors && computerRoshambo == Roshambo.Paper ||
                userRoshambo == Roshambo.Paper && computerRoshambo == Roshambo.Rock)
            {
                Console.WriteLine(name + " wins!");
                return 1;
            }
            else if (userRoshambo == Roshambo.Rock && computerRoshambo == Roshambo.Paper ||
                userRoshambo == Roshambo.Scissors && computerRoshambo == Roshambo.Rock ||
                userRoshambo == Roshambo.Paper && computerRoshambo == Roshambo.Scissors)
            {
                Console.WriteLine(computerPlayer.name + " wins!");
                return -1;
            }
            else
            {
                Console.WriteLine("Error in Program.cs.");
                return Int32.MaxValue;
            }
            
        }
    }
}
