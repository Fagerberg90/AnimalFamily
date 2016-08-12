using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFamily
{
    public class Ball
    {
        private string colour;
        private int quality;

        public Ball(string colour, int quality)
        {
            this.colour = colour;
            this.quality = 10;

        }
        public void LowerQuality(int number)
        {
            if (quality > 0)
            {
                quality = quality - number;
                Console.WriteLine("The " + colour + " ball took some damage");
            }
            else
            {
                Console.WriteLine("The " + colour + " ball is broken");
            }
        }
        public override string ToString()
        {
            return $"The {colour} ball has {quality} left";
        }
    }
}
