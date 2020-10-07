using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class YahtzeeGame
    {
        private Dice[] Dice = new Dice[5];
        public YahtzeeGame()
        {
            Random rng = new Random();
            for(int i = 0; i < Dice.Length; i++)
            {
                Dice[i] = new Dice(rng);
            }
        }

        public void Throw()
        {
            foreach(Dice d in Dice)
            {
                d.Throw();
            }
        }

        public void DisplayValues()
        {
            foreach (Dice d in Dice)
            {
                d.DisplayValue();
            }
        }

        public bool Yahtzee()
        {
            bool yahtzee = false;
            int last = 0;

            for(int i =0; i < Dice.Length; i++)
            {
                if (i == 0)
                {
                    last = Dice[i].Value;
                }
                else if (last == Dice[i].Value)
                {
                    yahtzee = true;
                }
                else
                {
                    yahtzee = false;
                    break;
                }

            }

            return yahtzee;
        }
    }
}
