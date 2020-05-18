using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        
        public override void ChooseName()
        {
            Console.WriteLine("Enter Player Name: ");
            name = Console.ReadLine();
        }

        public override void ChooseGesture() //display gesture choices
        {
            Console.WriteLine("Choose a Gesture ROCK, PAPER, SCISSORS, LIZZARD, or SPOCK: ");
            gesture = Console.ReadLine();
            gesture = gesture.ToUpper(); //convert string to upper case
            Console.WriteLine(name + " chose " + gesture);
            //list method contains 
           
            

        }
    }
}
