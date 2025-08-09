using System;

namespace AnimalSounds
{
    // Base class Animal
    public class Animal
    {
        // Virtual method that can be overridden by derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of each class
            Animal genericAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            // Call MakeSound on each instance
            Console.WriteLine("Generic Animal says: ");
            genericAnimal.MakeSound();

            Console.WriteLine("\nDog says: ");
            myDog.MakeSound();

            Console.WriteLine("\nCat says: ");
            myCat.MakeSound();

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
