using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMGTechnicalTestMVC.Models
{
    public class GameHelper
    {
        public Game GetResults(Game game)
        {
            //Instantite new game object and set values
            Game newGame = new Game();
            game.ComputerChoice = generateComputerChoice();

            determineResult(game);

            return game;
        }

        private static String generateComputerChoice()
        {
            String computerChoice = "";
            Random random = new Random();

            //Generate a selection for computer
            switch (random.Next(1,4))
            {
                //Computer gets 1, rock
                case 1:
                    computerChoice = "rock";
                    break;
                //Computer gets 2(paper)
                case 2:
                    computerChoice = "paper";
                    break;

                //Computer gets 3(paper)
                case 3:
                    computerChoice = "scissors";
                    break;
            }

            return computerChoice;
        }

        //Determine the result
        private static Game determineResult(Game game)
        {
            switch (game.PlayerChoice)
            {
                //Player chose rock
                case "rock":
                    if (game.ComputerChoice == "rock")
                    {
                        game.GameResult = "You both chose rock, it is a draw!";
                    }
                    else if (game.ComputerChoice == "paper")
                    {
                        game.GameResult = "Computer chose paper, paper wraps rock. Computer wins!";
                    }
                    else
                    {
                        game.GameResult = "Computer chose scissors, rock crushes scissors. You win!";
                    }
                    break;

                //Player chose paper
                case "paper":
                    if (game.ComputerChoice == "rock")
                    {
                        game.GameResult = "Computer chose rock, paper wraps rock. You win!";
                    }
                    else if (game.ComputerChoice == "paper")
                    {
                        game.GameResult = "You both chose paper, it is a draw!";
                    }
                    else
                    {
                        game.GameResult = "Computer chose scissors, scissors cuts paper. Computer wins!";
                    }
                    break;

                //Player chose scissors
                case "scissors":
                    if (game.ComputerChoice == "rock")
                    {
                        game.GameResult = "Computer chose rock, rock crushes scissors. Computer wins!";
                    }
                    else if (game.ComputerChoice == "paper")
                    {
                        game.GameResult = "Computer chose paper, scissors cuts paper. You win!";
                    }
                    else
                    {
                        game.GameResult = "You both chose scissors, it is a draw!";
                    }
                    break;
            }

            return game;
        }
    }
}
