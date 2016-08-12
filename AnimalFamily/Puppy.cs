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

        public Puppy(int age, string name, string fav_food, string breed, bool hungry,int months) : base(age, name, fav_food, breed, hungry)
        {
            Months = months;
        }

        public override string Interact(Ball ball)
        {
            ball.LowerQuality(2);
            return base.Interact(ball);
        }

        public override string ToString()
        {
           return $"my puppy name is {name} and i am {Months} month old";
    }
    }
}