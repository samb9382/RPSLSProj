using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public override ChooseName()
        {
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
        }

        public override ChooseGesture() //display gesture choices
        {
            Console.WriteLine("Choose a Gesture: ");
            gesture = Console.ReadLine();
        }
    }
}
