using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public enum RockPaperScissors
    {
        rock = 1,
        paper = 2,
        scissors = 3
    }

    public class PlayGame
    {
        public RockPaperScissors PlayerChoice()
        {
            Console.WriteLine();
            RockPaperScissors RPS = RockPaperScissors.rock;
            string input;
            bool _isValidChoice = false;
            do
            {
                Console.Write("Rock(r), Paper(p), or Scissors(s)? ");
                input = Console.ReadLine();
                if (input.ToUpper() == "R" || input.ToUpper() == "ROCK")
                {
                    RPS = RockPaperScissors.rock;
                    _isValidChoice = true;
                }
                if (input.ToUpper() == "P" || input.ToUpper() == "PAPER")
                {
                    RPS = RockPaperScissors.paper;
                    _isValidChoice = true;
                }
                if (input.ToUpper() == "S" || input.ToUpper() == "SCISSORS")
                {
                    RPS = RockPaperScissors.scissors;
                    _isValidChoice = true;
                }

            } while (_isValidChoice == false);
            return RPS;
        }

        public RockPaperScissors ComputerChoice(Random random)
        {
            int r = random.Next(1, 4);
            RockPaperScissors computerchoice = (RockPaperScissors)r;
            return computerchoice;
        }

        public void Calculate(RockPaperScissors p1, RockPaperScissors c1)
        {
            Console.WriteLine("You chose {0}, Computer chooses {1}.", p1, c1);
            // Player & Computer tie.
            if (p1 == c1)
            {
                Console.WriteLine("You both chose {0}. There is a tie!", p1);
            }
            // Player chooses rock.
            else if (p1 == RockPaperScissors.rock)
            {
                if (c1 == RockPaperScissors.paper)
                {
                    Console.WriteLine("Paper covers rock. Computer wins.");
                }
                else
                    Console.WriteLine("Rock destroys scissors. You win!!");
            }
            // Player chooses paper.
            else if (p1 == RockPaperScissors.paper)
            {
                if (c1 == RockPaperScissors.rock)
                    Console.WriteLine("Paper covers rock. You win!!");
                else
                {
                    Console.WriteLine("Scissors cuts paper. Computer wins.");
                }
            }
            // Player chooses scissors.
            else
            {
                if (c1 == RockPaperScissors.rock)
                {
                    Console.WriteLine("Rock destroys scissors. Computer wins.");
                }
                else
                {
                    Console.WriteLine("Scissors cuts paper. You win!!");
                }
            }
        }

        public bool PromptNewGame()
        {
            bool prompt = false;
            string newgame = "";
            while (prompt == false)
            {
                Console.Write("Play another game (y/n)? ");
                newgame = Console.ReadLine();
                if (newgame.ToUpper() == "Y" || newgame.ToUpper() == "YES"
                    || newgame.ToUpper() == "N" || newgame.ToUpper() == "NO")
                    prompt = true;
            }
            if (newgame.ToUpper() == "Y" || newgame.ToUpper() == "YES")
                return true;
            return false;
        }
    }
}

