﻿using System;

// Define the interface
interface IMovable
{
    void Move();
}

// Car class implementing IMovable
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

// Bicycle class implementing IMovable
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Car and Bicycle
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        // Call the Move method
        Console.WriteLine("Car:");
        car.Move();

        Console.WriteLine("Bicycle:");
        bicycle.Move();
    }
}
