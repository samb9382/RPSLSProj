using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {

        public override void ChooseGesture() //random gesture for the computer using int
        {
             
            Random random = new Random();
            List<string> gestures = new List<string> {"ROCK", "PAPER", "SCISSORS", "LIZZARD", "SPOCK" };
            gesture = gestures[random.Next(0, 4)];
            
            Console.WriteLine("Computer choose " + gesture);

        }

        public override void ChooseName()
        {
            name = "Computer";
        }
    }
}
