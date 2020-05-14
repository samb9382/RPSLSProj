using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        public int playerOneScore;
        public int playerTwoScore;

        public void ChooseNumberPlayers()
        {
            Console.WriteLine("Type 1 for single player option  OR Type 2 for 2 players");
            string choosePlayerOption = Console.ReadLine();
            switch (choosePlayerOption)
            {
                case "1":
                    playerOne = new Human();
                    playerTwo = new Computer();
                    playerOne.ChooseName();// need to grab playerOne name
                    break;
                case "2":
                    playerOne = new Human();
                    playerTwo = new Human();
                    playerOne.ChooseName();// need both names for players
                    playerTwo.ChooseName();
                    break;
                default:
                    Console.WriteLine("NOT AN OPTION");
                    ChooseNumberPlayers();
                    break;

            }
        }
        public void PointWinner()
        {
            if (playerOne.gesture == playerTwo.gesture)
            {
                Console.WriteLine("tie");
            }
            else if ()
            {
                
            }
            

           
        }
        public void RunGame()
        {
            Console.WriteLine("welcome to the game");
            ChooseNumberPlayers();

        }

    }
}

