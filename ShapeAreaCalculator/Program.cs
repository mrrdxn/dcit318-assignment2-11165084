using System;

// Abstract base class
abstract class Shape
{
    public abstract double GetArea();
}

// Circle class
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Rectangle class
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        // Create Circle instance
        Circle circle = new Circle(5.0);
        Console.WriteLine($"Circle with radius {circle.Radius} has area: {circle.GetArea():F2}");

        // Create Rectangle instance
        Rectangle rectangle = new Rectangle(4.0, 6.0);
        Console.WriteLine($"Rectangle with width {rectangle.Width} and height {rectangle.Height} has area: {rectangle.GetArea():F2}");
    }
}
