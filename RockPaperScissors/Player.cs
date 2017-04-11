using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player
    {
        public string name { get; protected set; }
        
        abstract public Roshambo generateRoshambo();             
    }
}
