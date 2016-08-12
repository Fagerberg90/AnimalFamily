using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFamily
{
    public class Dog : Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Dog(int age, string name, string fav_food, string breed, bool hungry) : base(age, name, fav_food, breed, hungry)
        {
            Name = name;
            Age = age;
            fav_food = "dog food";
        }




        public override string Interact(Ball ball)
        {
            return base.Interact(ball);
        }




        public override string ToString()
        {
            return $"the dogs name is {name} and the breeds are {breed} and he is {age} years old. The best food is {fav_food}";
        }
    }
}