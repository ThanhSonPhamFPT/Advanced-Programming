using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassObject
{
    internal class Dice
    {
        public int Sides { get; set; }
        public Dice(int sides)
        {
            this.Sides = sides;
        }
        public int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(1, Sides + 1);

        }
        
    }
}
