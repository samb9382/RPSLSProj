﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player //Parent class
    {
        public string name;
        public string gesture;
        int score;


        //abstract methods
        public abstract void ChooseGesture();
        public abstract void ChooseName();


    }
}
