using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFamily
{
    public class Animal
    {
        protected int age;                  //Protected field
        protected string name;
        protected string fav_food;
        protected string breed;
        protected bool hungry;

        public Animal(int age, string name, string fav_food, string breed, bool hungry)    //constructor
        {
          
        }

        public void Eat(string food, Animal animal)     //method with two inparamters and check if the animal are hungry
        {
            if (food == animal.fav_food)
            {
                animal.hungry = false;
            }

            else
            {
                HungryAnimal();
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