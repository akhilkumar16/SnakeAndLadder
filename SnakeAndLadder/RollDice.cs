using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class RollDice
    {
        //UC2
        public int rollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);     //To Get random number between 1 to 6
            return dice;
        }
        /* UC3:- The Player then checks for a Option. They are No Play, Ladder or Snake. */
        public int checkOption()
        {
            Random random = new Random();
            int option = random.Next(1, 4);
            return option;
        }
    }
}