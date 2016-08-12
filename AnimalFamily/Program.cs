﻿using System;
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
            

            var animalCat = new Cat(10, "KALLE", "cat food", "farmcat", true);
          

            var animalDog = new Dog(7, "Dexter", "dog food", "schäfer", false);
            

            var animalPuppy = new Puppy(1, "Cassie", "puppyfood", "boxer", true);

            var animals = new List<Animal>();

            animals.Add(animalCat);
            animals.Add(animalDog);
            animals.Add(animalPuppy);
            

            var playBall = new Ball("red", 10);

            var ownerName = new PetOwner("Joppe", 24, animals, playBall);

       

            ownerName.Menu();


         
            



        }
    }
}
