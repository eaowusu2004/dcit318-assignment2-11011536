using System;

namespace ShapesDemo
{
    // Abstract base class
    public abstract class Shape
    {
        // Abstract method that must be implemented by derived classes
        public abstract double GetArea();
    }

    // Derived class Circle
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implementing the abstract method
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implementing the abstract method
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a Circle with radius 5
            Circle circle = new Circle(5);
            Console.WriteLine($"Circle with radius {circle.Radius} has area: {circle.GetArea():F2}");

            // Create a Rectangle with width 4 and height 6
            Rectangle rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Rectangle {rectangle.Width}x{rectangle.Height} has area: {rectangle.GetArea()}");

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
