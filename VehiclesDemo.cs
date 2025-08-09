using System;

namespace VehiclesDemo
{
    // Interface definition
    public interface IMovable
    {
        void Move();
    }

    // Car class implementing IMovable
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Bicycle class implementing IMovable
    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    // Another class to demonstrate multiple interface implementation
    public class Drone : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Drone is flying");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of classes that implement IMovable
            IMovable car = new Car();
            IMovable bicycle = new Bicycle();
            IMovable drone = new Drone();

            // Call Move() on each instance
            Console.WriteLine("Starting the vehicles:");
            car.Move();
            bicycle.Move();
            drone.Move();

            // Demonstrate polymorphism with an array of IMovable
            Console.WriteLine("\nMoving all vehicles in a loop:");
            IMovable[] vehicles = { new Car(), new Bicycle(), new Drone() };
            
            foreach (var vehicle in vehicles)
            {
                vehicle.Move();
            }

            // Keep the console window open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
