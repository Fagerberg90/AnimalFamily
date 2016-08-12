using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFamily
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalCat = new Cat(10, " Kalle", "cat food", "farmcat", true);
            var animalDog = new Dog(7, " Dexter", "dog food", "schäfer", false);
            var animalPuppy = new Puppy(0, "Cassie", "puppyfood", "boxer", true,5);

            var animals = new List<Animal>();

            animals.Add(animalCat);
            animals.Add(animalDog);
            animals.Add(animalPuppy);

            var playBall = new Ball("red", 10);


            var ownerName = new PetOwner("Joppe", 24, animals, playBall);

            
            ownerName.Menu();
           


            Console.ReadLine();
       }
    }
}
