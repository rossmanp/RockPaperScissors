using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Lisa : Player
    {
        public override Roshambo generateRoshambo()
        {
            name = "Lisa";

            int play = 0;
            Random rnd = new Random();
            play = rnd.Next(1, 4);
            switch (play)
            {
                case 1:
                    return Roshambo.Paper;                   
                case 2:
                    return Roshambo.Rock;                   
                case 3:
                    return Roshambo.Scissors;                   
                default:
                    Console.WriteLine("Error!");
                    break;
            }
            return Roshambo.Error;          
        }
    }
}
