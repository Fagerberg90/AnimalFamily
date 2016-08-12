using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFamily
{
    public class Cat : Animal
    {
        public Cat(int age, string name, string fav_food, string breed, bool hungry) : base(age, name, fav_food, breed, hungry)
        {
            fav_food = HungryAnimal();
        }

        public override string HungryAnimal()
        {
            var rnd = new Random();
            var musjakt = rnd.Next(1, 100);
            if (musjakt >= 50)
            {
                return "found a mouse in the wood";
            }
            else
            {
                return "Still looking/hunting for food...";
            }
        }

        public override string Interact(Ball ball)
        {
            ball.LowerQuality(1);
            return base.Interact(ball);
        }

        public override string ToString()
        {
            return $"my cats name is {name} and i am {age} years old. My best food is {fav_food}";
        }
    }
}
