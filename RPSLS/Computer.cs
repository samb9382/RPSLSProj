using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        public override void ChooseGesture() //random gesture for the computer
        {
            
            
            Random random = new Random();
        }

        public override void ChooseName()
        {
            name = "Computer AI";
        }
    }
}
