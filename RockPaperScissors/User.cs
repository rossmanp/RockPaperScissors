using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class User : Player
    {
        public override Roshambo generateRoshambo()
        {
            bool run = true;
            string play = "";
            Console.Write("\nRock, Paper, or Scissors? (R/P/S):");
            while (run)
            { 
                try
                {
                    run = false;
                    string throws = "RPS";
                    play = Console.ReadLine().ToUpper();                   
                    bool containsRPS = throws.Contains(play);
                    if (containsRPS == false || play.Length > 1 || play.Length == 0)
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That was not valid input! Please input R, P, or S.");
                    run = true;
                }
            }
            if (play.Equals("R"))
            {
                return Roshambo.Rock;
            }
            else if (play.Equals("P"))
            {
                return Roshambo.Paper;
            }
            else if (play.Equals("S"))
            {
                return Roshambo.Scissors;
            }
            else
            {
                Console.WriteLine("Error in User.cs");
                return Roshambo.Error;
            }
        }       
    }
}
