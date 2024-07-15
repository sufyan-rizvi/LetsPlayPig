using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsPlayPig.Models;

namespace LetsPlayPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Turn(game);
        }

        static void PrintInsideTurn(Game game)
        {
            
            while ((game.TotalScore + game.TurnScore) <= 20 )
            {

                Console.WriteLine("\nEnter 'r' to roll again, 'h' to hold.\n");

                game.UserReply = Console.ReadLine();


                if (game.UserReply == "r")
                {

                    game.RollDice();

                    Console.WriteLine($"You Rolled: {game.DiceRollValue}");

                    if (game.DiceRollValue == 1)
                    {
                        Console.WriteLine("Turn Over. No Score");
                        game.IncrementTurnNumber();
                        game.TotalScore = 0;
                        game.TurnScore = 0;
                        break;
                    }
                    else
                    {
                        game.IncrementTurnScore();

                        Console.WriteLine($"Your turn score is {game.TurnScore} and you total score is {game.TotalScore}");

                        Console.WriteLine($"If you hold, you will have {game.TurnScore + game.TotalScore} points.");
                    }
                }
                else
                {
                    game.IncrementTurnNumber();
                    game.IncrementTotalScore();
                    Console.WriteLine($"Your turn score is {game.TurnScore} and total score is {game.TotalScore}\n");
                    game.TurnScore = 0;
                    break;
                }



            }
        }

        static void Turn(Game game)
        {
            while (true)
            {
                Console.WriteLine($"\nTurn{game.TurnNumber}\n");

                if (game.TurnNumber == 1 || game.DiceRollValue == 1)
                {
                    Console.WriteLine("Welcome to the game of Pig\n");
                }

                PrintInsideTurn(game);

                if (game.TotalScore + game.TurnScore >= 20)
                {
                    Console.WriteLine($"\nYou Win! You finished in {game.TurnNumber} turns\n");
                    break;
                }
            }
        }
    }
}
