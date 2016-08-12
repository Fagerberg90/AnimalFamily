using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFamily
{
    public class Puppy : Dog
    {
        public int Months { get; set; }

        public Puppy(int age, string name, string fav_food, string breed, bool hungry) : base(age, name, fav_food, breed, hungry)
        {
            
            age = 0;
        }



        public override string Interact(Ball ball)
        {
            return base.Interact(ball);
        }


        public override string ToString()
        {
           return $"the puppys name is {Name} and is {Months} month old";
    }
    }
}