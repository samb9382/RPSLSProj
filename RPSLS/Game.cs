using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        public int playerOnePoint;
        public int playerTwoPoint;

        public void ChooseNumberPlayers()
        {
            Console.WriteLine("Type 1 for single player option  OR Type 2 for 2 players");
            string choosePlayerOption = Console.ReadLine();
            switch (choosePlayerOption)
            {
                case "1":
                    playerOne = new Human();
                    playerTwo = new Computer();
                    // need to grab playerOne name
                    break;
                case "2":
                    playerOne = new Human();
                    playerTwo = new Human();
                    //need to grab both player names
                    break;
                default:
                    Console.WriteLine("NOT AN OPTION");
                    ChooseNumberPlayers();
                    break;


            }
        }
    }
}
