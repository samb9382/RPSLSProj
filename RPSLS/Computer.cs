using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        public string cpuInput;
        public int randomGesture;

        public override void ChooseGesture() //random gesture for the computer using int
        {
             
            Random random = new Random();
            randomGesture = random.Next(1, 5);

            switch (randomGesture)
            {
                case 1:
                    cpuInput = "Rock";
                    break;
                case 2:
                    cpuInput = "paper";
                    break;
                case 3:
                    cpuInput = "Scissors";
                    break;
                case 4:
                    cpuInput = "Lizzard";
                    break;
                case 5:
                    cpuInput = "Spock";
                    break;

      
            }

        }

        public override void ChooseName()
        {
            name = "Computer AI";
        }
    }
}
