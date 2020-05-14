using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public string playerGesture;
        public override void ChooseName()
        {
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
        }

        public override void ChooseGesture() //display gesture choices
        {
            Console.WriteLine("Choose a Gesture ROCK, PAPER, or SCISSORS: ");
            playerGesture = Console.ReadLine();
            playerGesture = playerGesture.ToUpper();
            Console.WriteLine(name + " chose " + playerGesture);

           
            

        }
    }
}
