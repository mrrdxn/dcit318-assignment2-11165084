using System;

// Base class
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class Dog
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

// Derived class Cat
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main()
    {
        // Create instances
        Animal genericAnimal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        // Call MakeSound() on each
        Console.WriteLine("Animal sound:");
        genericAnimal.MakeSound();

        Console.WriteLine("Dog sound:");
        dog.MakeSound();

        Console.WriteLine("Cat sound:");
        cat.MakeSound();
    }
}
