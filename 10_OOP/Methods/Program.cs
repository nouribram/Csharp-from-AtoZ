/*
  Topic: C# Object-Oriented Programming (OOP) Introduction
  OOP (Object-Oriented Programming) is a programming paradigm 
  based on the concept of **objects** — which combine data (fields) 
  and behavior (methods) into a single unit.

  C# is a fully object-oriented language that supports the 4 main OOP principles:
  1. Encapsulation
  2. Inheritance
  3. Polymorphism
  4. Abstraction
*/

using System;

namespace OOPIntro
{
    // Example: Class and Object
    public class Car
    {
        // Fields (Attributes)
        public string Brand;
        public string Model;
        public int Year;

        // Constructor
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        // Method (Behavior)
        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}, Year: {Year}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating Objects (Instances)
            Car car1 = new Car("Toyota", "Corolla", 2022);
            Car car2 = new Car("BMW", "X5", 2023);

            // Using Object Methods
            car1.DisplayInfo();
            car2.DisplayInfo();
        }
    }
}

/*
  OOP Key Concepts Summary:
  
  - Encapsulation → Protects data by bundling variables and methods inside a class.
  - Inheritance → Allows one class to derive from another (reuse code).
  - Polymorphism → Allows methods to behave differently based on the object type.
  - Abstraction → Hides complex details and exposes only essential features.

  Think of a class as a "blueprint" and objects as "real-world instances" 
  created from that blueprint.
*/
