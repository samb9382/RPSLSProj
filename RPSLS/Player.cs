using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
      abstract class Player //Parent class
    {
        public string name;
        public string gesture;
        int numberOfWins;


        //abstract methods
        public abstract void ChooseGesture();
        public abstract void ChooseName();



    }
}
