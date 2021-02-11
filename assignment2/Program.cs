using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program yahtzee = new Program();
            yahtzee.Start();
        }
        void Start()
        {

            YahtzeeGame yahtzeeGame = new YahtzeeGame();
            PlayYahtzee(yahtzeeGame); // play the game
            Console.ReadKey();
        }

        void PlayYahtzee(YahtzeeGame game)
        {
            int nrOfAttempts = 0;
            do
            {
                game.Throw(); // throw all dices
                game.DisplayValues(); // display the thrown
                Console.WriteLine();
                nrOfAttempts++;
            } while (!game.Yahtzee());
            Console.WriteLine("Number of attempts needed (for Yahtzee): {0}", nrOfAttempts);
        }
    }
}

