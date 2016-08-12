using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFamily
{
    public abstract class Animal
    {
        protected int age;                  //Protected field
        public string name { get; protected set; }
        protected string fav_food;
        protected string breed;
        protected bool hungry;

        public Animal(int age, string name, string fav_food, string breed, bool hungry)    //constructor
        {
            this.age = age;
            this.name = name;
            this.fav_food = fav_food;
            this.breed = breed;
            this.hungry = hungry;
        }

        public void Eat(string food)     //method with two inparamters and check if the animal are hungry
        {
            Console.WriteLine("Feeding" + " " + name + " " + food);

            if (food == fav_food && hungry == true)
            {
                hungry = false;
                Console.WriteLine("nom nom nom");
            }
            else if (hungry == true)
            {
                Console.WriteLine(HungryAnimal());
            }
            else
            {
                Console.WriteLine(name + " is not hungry");
            }
        }
        public virtual string Interact(Ball ball)           //See how much the ball can take
        {
            return $"When {name} have played with the {ball} its still fine";
        }
        public virtual string HungryAnimal()    // standard text if the animal is hungry
        {
            return $"Give the right food....";
        }
    }
}