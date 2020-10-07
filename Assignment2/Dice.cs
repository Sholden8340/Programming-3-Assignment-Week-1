using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Dice
    {
        public int Value { get; set; }

        private Random rng;

        public Dice(Random rng)
        {
            this.rng = rng;
        }


        public void Throw()
        {
            Value = rng.Next(1, 7);
        }

        public void DisplayValue()
        {
            Console.Write(" " + Value);
        }

        public int Getvalue()
        {
            return Value;
        }

        public void SetValue(int value)
        {
            this.Value = value;
        }
    }


}
