using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFamily
{
    public class Dog : Animal
    {
        public Dog(int age, string name, string fav_food, string breed, bool hungry) : base(age, name, fav_food, breed, hungry)
        {

        }
        public override string Interact(Ball ball)
        {
            ball.LowerQuality(3);
            return base.Interact(ball);
        }

        public override string ToString()
        {
            return $"my dogs name is {name} and i am a {breed} and is {age} years old. The best food is {fav_food}";
        }
    }
}