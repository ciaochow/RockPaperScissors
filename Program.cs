using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop == true)
            {
                Random random = new Random();
                PlayGame PlayGame = new PlayGame();
                Console.Clear();
                Console.WriteLine("--------------- Rock, Paper, Scissors ---------------");
                var p1 = PlayGame.PlayerChoice();
                var c1 = PlayGame.ComputerChoice(random);
                PlayGame.Calculate(p1, c1);
                loop = PlayGame.PromptNewGame();
            }
        }
    }
}
