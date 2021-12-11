using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Farm
    {
        List<Animal> myFarm = new List<Animal>();

        public Farm()
        {
            myFarm.Add(new Cow());
            myFarm.Add(new Pig());
            myFarm.Add(new Dog());
            myFarm.Add(new Duck());
            myFarm.Add(new Cat());
            myFarm.Add(new Sheep());
            myFarm.Add(new Chicken());
            myFarm.Add(new Bee());
            myFarm.Add(new Horse());
            myFarm.Add(new Goose());
        }

        public void PrintSong()
        {
            foreach (var animal in myFarm)
            {
                Console.WriteLine("Old MacDonald had a farm, E I E I O,\n" +
                                   "And on his farm he had a {0}, E I E I O.\n" +
                                   "With a {1} {1} here and a {1} {1} there,\n" +
                                   "Here a {1}, there a {1}, ev'rywhere a {1} {1}.\n" +
                                   "Old MacDonald had a farm, E I E I O.\n", animal.getAnimalBreed(), animal.getSong());
            }
        }


        public void AnotherAnimal()
        {
            Console.WriteLine("Do you want to add another animal? Y/N");
            var answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
                myFarm.Clear();
                Console.WriteLine("Please enter the animal breed");
                string animalBreed = Console.ReadLine();
                Console.WriteLine("Please enter the animal sound");
                string animalSound = Console.ReadLine();
                myFarm.Add(new UserAnimal(animalBreed, animalSound));
                PrintSong();
            }
        }

    }

}


