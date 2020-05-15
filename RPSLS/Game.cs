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

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizzard Spock.");
            Console.WriteLine("You can play vs a friend or against a computer.");
            Console.WriteLine("In order to win, Paper disproves spock and covers rock. scissors cuts paper and decapitates lizzard. Spock smashes scissors and vaporizes rock. Lizzard poisons spock and eats paper. Rock crushes scissors and crushes lizzard.");
            Console.WriteLine("First player to 2 wins is the winner! Good Luck!");
        }

        
        
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
                Console.WriteLine("It's a tie");
            }
            else if (playerOne.gesture == "ROCK" && playerTwo.gesture == "SCISSORS") || (playerOne.gesture == "ROCK" && playerTwo.gesture == "LIZZARD") || (playerOne.gesture == "PAPER" && playerTwo.gesture == "ROCK") || (playerOne.gesture == "PAPER" && playerTwo.gesture == "SPOCK") || (playerOne.gesture == "SCISSORS" && playerTwo.gesture == "PAPER") || (playerOne.gesture == "SCISSORS" && playerTwo.gesture == "LIZARD") || (playerOne.gesture == "SPOCK" && playerTwo.gesture == "SCISSORS") || (playerOne.gesture == "SPOCK" && playerTwo.gesture == "ROCK") || (playerOne.gesture == "LIZARD" && playerTwo.gesture == "SPOCK") || (playerOne.gesture == "LIZARD" && playerTwo.gesture == "PAPER"); 
            {
                Console.WriteLine("Player One Wins this round"); //add name to console
                //playerOne point ++

            }
            else
            {
                Console.WriteLine("Player Two Wins this round"); //add name to console
                //playerTwo point ++
            }
            

           
        }
        public void RunGame()
        {
            Console.WriteLine("welcome to the game!");
            DisplayRules();
            ChooseNumberPlayers();

        }

    }
}

