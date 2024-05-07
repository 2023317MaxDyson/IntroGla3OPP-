namespace OOPGLA3MaxDyson
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }

        public Animal()
        {
            Name = "Animal";
            Legs = 0;
        }

        public virtual string GetName()
        {
            return Name;
        }
        public virtual string GetLegs()
        {
            return Legs.ToString();
        }
        public virtual string GetSpecialAbility()
        {
            return "\nEating...";
        }
        public string Display()
        {
            return GetName() + " " + GetLegs() + GetSpecialAbility();
        }
        public override string ToString()
        {
            return Display() + "\n";
        }
    }

    public class Dog : Animal
    {
        //Complete the constructor for Dog and GetSpecialAbility() function
        public Dog()
        {
            //ToDo
            //Set the dog name "Dog" and Legs to be 4

            Name = "Dog";
            Legs = 4;
        }
        public override string GetSpecialAbility()
        {
            //ToDo
            //replace return null and return dogs special ability "Woof";

            return '\n' + "Woof" ;
        }
    }

    public class Fish : Animal
    {
        //TODO
        //Complete the constructor for Fish and GetSpecialAbility() function
        public Fish()
        {
            // Name is Fish and Legs is 0

            Name = "Fish";
            Legs = 0;
        }

        public override string GetSpecialAbility()
        {
            return '\n' + "Just keep swimming";
        }
    }

    public class Shark : Fish
    {
        //TODO
        //Complete the constructor for Shark and GetSpecialAbility() function
        //Shark Takes the last animal as parameter to the constructor method.
        //Shark ate the last animal as the SpecialAbility.



        //  Animal class variable 
        public Animal lastAnimal;
     
        public Shark(Animal animal) 
        {

            // Name is Shark, Legs is 0 and Animal class variable lastAnimal is equal to the last animal
            Name = "Shark";
            Legs = 0;
            lastAnimal = animal;


        }


        public override string GetSpecialAbility()
        {
            
                                            
             // Using the GetName method that looks for the last Animal
            return '\n' + "Skark ate" + " " + lastAnimal.GetName();
            
        }


    }
    
    class Program
    {
        static void Main(string[] args)
        {
            /* The main method is complete. 
             * You do not need to modify the main method code.
             */

            Animal lastAnimal = null;
            Animal animal = null;
            string input;
            while ((input = Console.ReadLine()) != "exit")
            {
                if (input == "animal")
                {
                    animal = new Animal();
                    lastAnimal = animal;
                }
                else if (input == "dog")
                {
                    animal = new Dog();
                    lastAnimal = animal;

                }
                else if (input == "fish")
                {
                    animal = new Fish();
                    lastAnimal = animal;

                }
                else if (input == "shark")
                {
                    animal = new Shark(lastAnimal);
                    lastAnimal = animal;
                }
                else if (input == "exit")
                {
                    return;
                }

                Console.WriteLine(animal);
            }
        }
    }
}

    // Sample Outputs


    /*Command Words
    animal
    dog
    fish
    shark
    exit

    Sample Input/Output 1:

    animal
    Animal 0
    Eating...

    dog
    Dog 4
    Woof

    fish
    Fish 0
    Just keep swimming

    shark
    Shark 0
    Shark ate Fish

    exit
    ---------------------------
    */


    /*Command words
    animal
    shark
    fish
    shark
    dog
    shark
    shark
    exit


    Sample Input/Output 2:

    animal
    Animal 0
    Eating...

    shark
    Shark 0
    Shark ate Animal

    fish
    Fish 0
    Just keep swimming

    shark
    Shark 0
    Shark ate Fish

    dog
    Dog 4
    Woof

    shark
    Shark 0
    Shark ate Dog

    shark
    Shark 0
    Shark ate Shark

    exit
    */

