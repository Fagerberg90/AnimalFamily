using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFamily
{
    public class PetOwner
    {
        private string ownerName;
        private int age;
        private List<Animal> pets;
        private Ball ball;

        public PetOwner(string ownerName, int age, List<Animal> pets, Ball ball)
        {
            this.ownerName = ownerName;
            this.age = age;
            this.pets = pets;
            this.ball = ball;
        }
        public void Menu()
        {
            string choice = string.Empty;

          
            Console.WriteLine("---- Menu ----\n");

            Console.WriteLine("Choose a option for me.");

            Console.WriteLine("\n1. Play fetch ");
            Console.WriteLine("2. Feed animal");
            Console.WriteLine("3. List animals ");
            Console.WriteLine("4. Exit ");
            Console.WriteLine();
            Console.WriteLine("Enter choice:");
            Console.WriteLine();

            choice = Console.ReadLine();

            switch (choice)   // which number you take it goes to a method.
            {
                case "1":
                    Fetch();
                    break;
                case "2":
                    Feed("animal food");
                    break;
                case "3":
                    ListAnimals();
                    break;
                case "4":
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("--try again--");
                    break;
            }
            Console.ReadLine();
            Menu();
        }
        public void Feed(string food)
        {
            Console.WriteLine("[D]og food");
            Console.WriteLine("[P]uppy food");
            Console.WriteLine("[C]at food");
            Console.WriteLine("[E]xit");

            string input = Console.ReadLine();

            switch (input.ToUpper())
            {
                case "D":
                    foreach (Animal petDog in pets)
                    {
                        var dog = petDog as Dog; //sätter varje djur som klassen dog
                        if (dog != null) //om detta lyckas, dvs dog inte är null
                        {
                            petDog.Eat("dog food");
                        }
                    }
                    break;
                case "P":
                    foreach (Animal petPuppy in pets)
                    {
                        var puppy = petPuppy as Puppy;
                        if (puppy != null)
                        {
                            petPuppy.Eat("puppy food");
                        }
                    }
                    break;
                case "C":
                    foreach (Animal petCat in pets)
                    {
                        var cat = petCat as Cat;
                        if (cat != null)
                        {
                            petCat.Eat("cat food");
                        }
                    }
                    break;
                case "E":
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Wrong, try again");
                    break;
            }
        }
        public void CheckBall()
        {
            Console.WriteLine(ball.ToString());
        }
        public void Fetch()
        {
            Console.WriteLine(" Throwing the ball ");

            foreach (Animal pet in pets)
            {
                Console.Write(pet.name + "," + " ");
            }

            Console.Write("is chasing the ball.");
            Random random = new Random();
            int randomNumber = random.Next(0, pets.Count());
            Console.WriteLine();
            Console.WriteLine(pets[randomNumber].name + " catches the ball and brings it back to you.");

            pets[randomNumber].Interact(ball);
            Console.WriteLine(ball.ToString());
        }
        public void ListAnimals()
        {
            foreach (Animal pet in pets)
            {
                Console.WriteLine(pet);
            }
        }

        public override string ToString()
        {
            return $"Hello. I am Joppe. I´m {age} years old and I have {pets.Count} animals!";
        }
    }
}