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
      

        public Ball(string colour,int quality)
        {
            this.colour = colour;
            this.quality = quality;
        
        }

    public void LowerQuality(int tal=0)
        {
            if (quality<tal)
            {
               
            }
          

        }

        public override string ToString()
        {
            return $"The {colour} ball has {quality} left.";
        }
    }
}
