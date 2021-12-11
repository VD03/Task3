using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Animal
    {
        public abstract string getAnimalBreed();
        public abstract string getSong();
    }

    public class UserAnimal : Animal
    {
        private string AnimalBreed;
        private string Sound;

        public UserAnimal(string animalBreed, string animalSound)
        {
            AnimalBreed = animalBreed;
            Sound = animalSound;
        }

        public override string getAnimalBreed()
        {
            return AnimalBreed;
        }

        public override string getSong()
        {
            return Sound;
        }
    }

    public class Cow : Animal
    {
        private string AnimalBreed;
        private string Sound;

        public Cow()
        {
            AnimalBreed = "cow";
            Sound = "moo";
        }

        public override string getAnimalBreed()
        {
            return AnimalBreed;
        }

        public override string getSong()
        {
            return Sound;
        }
    }

    public class Pig : Animal
    {
        private string AnimalBreed;
        private string Sound;

        public Pig()
        {
            AnimalBreed = "pig";
            Sound = "oink";
        }

        public override string getAnimalBreed()
        {
            return AnimalBreed;
        }

        public override string getSong()
        {
            return Sound;
        }
    }

    public class Dog : Animal
    {
        private string AnimalBreed;
        private string Sound;

        public Dog()
        {
            AnimalBreed = "dog";
            Sound = "aw";
        }

        public override string getAnimalBreed()
        {
            return AnimalBreed;
        }

        public override string getSong()
        {
            return Sound;
        }
    }

    public class Duck : Animal
    {
        private string AnimalBreed;
        private string Sound;

        public Duck()
        {
            AnimalBreed = "duck";
            Sound = "quack";
        }

        public override string getAnimalBreed()
        {
            return AnimalBreed;
        }

        public override string getSong()
        {
            return Sound;
        }
    }

    public class Cat : Animal
    {
        private string AnimalBreed;
        private string Sound;

        public Cat()
        {
            AnimalBreed = "cat";
            Sound = "meow";
        }

        public override string getAnimalBreed()
        {
            return AnimalBreed;
        }

        public override string getSong()
        {
            return Sound;
        }
    }

    public class Sheep : Animal
    {
        private string AnimalBreed;
        private string Sound;

        public Sheep()
        {
            AnimalBreed = "sheep";
            Sound = "baa";
        }

        public override string getAnimalBreed()
        {
            return AnimalBreed;
        }

        public override string getSong()
        {
            return Sound;
        }
    }

    public class Chicken : Animal
    {
        private string AnimalBreed;
        private string Sound;

        public Chicken()
        {
            AnimalBreed = "chicken";
            Sound = "cluck";
        }

        public override string getAnimalBreed()
        {
            return AnimalBreed;
        }

        public override string getSong()
        {
            return Sound;
        }
    }

    public class Bee : Animal
    {
        private string AnimalBreed;
        private string Sound;

        public Bee()
        {
            AnimalBreed = "bee";
            Sound = "buzz";
        }

        public override string getAnimalBreed()
        {
            return AnimalBreed;
        }

        public override string getSong()
        {
            return Sound;
        }
    }

    public class Horse : Animal
    {
        private string AnimalBreed;
        private string Sound;

        public Horse()
        {
            AnimalBreed = "horse";
            Sound = "neigh";
        }

        public override string getAnimalBreed()
        {
            return AnimalBreed;
        }

        public override string getSong()
        {
            return Sound;
        }
    }

    public class Goose : Animal
    {
        private string AnimalBreed;
        private string Sound;

        public Goose()
        {
            AnimalBreed = "goose";
            Sound = "sloquawk";
        }

        public override string getAnimalBreed()
        {
            return AnimalBreed;
        }

        public override string getSong()
        {
            return Sound;
        }
    }
}
