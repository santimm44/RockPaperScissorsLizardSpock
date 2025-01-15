using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock.services
{
    public class RockPaperScissorsLizardSpockService
    {
        public string GameMethod()
        {
            Random rng = new Random();
            string[] computerResponse = ["rock", "paper", "scissors", "lizard", "spock"];
            
            int randomNumber = rng.Next(5);

            return computerResponse[randomNumber];
        }
    }
}