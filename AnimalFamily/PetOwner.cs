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
      
        public PetOwner(string ownerName, int age, List<Animal> pets,Ball ball)
        {
            this.ownerName = ownerName;
            this.age = age;
            this.pets = pets;
            this.ball = ball;
        }
            public void Menu()
        {
            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("---- Menu ----");

                Console.WriteLine("1. Play fetch ");
                Console.WriteLine("2. Feed animal");
                Console.WriteLine("3. List animals ");
                Console.WriteLine("4. Exit ");
                Console.WriteLine();
                Console.WriteLine("Enter choice:");
                Console.WriteLine();


                switch (choice)   // which number you take it goes to a method.
                {
                    case 1:

                        Fetch(new Ball("red", 10));
                        break;
                    case 2:
                        Feed("animal food");
                        break;
                    case 3:
                        ListAnimals();
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("--try again--");
                        break;
                }
            }
            while (choice != 0);
        }

    

        public void Feed(string food)
        {
            
            Console.WriteLine("[D]og food");
            Console.WriteLine("[P]uppy food");
            Console.WriteLine("[C]at food");
            Console.WriteLine("[A]vsluta");
            string input = Console.ReadLine();

           

            switch (input.ToUpper())
            {
                case "D":
                    
                   
                   break;
                case "P":
                  
                    break;
                case "C":
                  
                    break;
                case "A":
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

        public void Fetch(Ball ball)
        {
            Console.WriteLine("hahahah");
            
        }

        public List<Animal> ListAnimals()
        {
            return pets;
        }

        public override string ToString()
        {
            return $"Hello. I am Joppe. I´m {age} years old and I have {pets.Count} animals!";
        }
    }
}