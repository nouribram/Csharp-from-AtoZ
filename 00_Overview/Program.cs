// ===========================================
// C# from the Inside Out Simple Breakdown for New Developers
// ===========================================

using System;
using System.Collections.Generic;
using System.Linq;

namespace AnatomyOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // === BASIC SYNTAX ===
            VariablesAndDataTypes();
            StringsAndInterpolation();
            Conditionals();
            Loops();
            ArraysAndLists();

            // === OOP (OBJECT-ORIENTED PROGRAMMING) ===
            ClassesAndObjects();
            InheritanceAndPolymorphism();
            InterfacesAndAbstraction();

            // === INTERMEDIATE ===
            ExceptionHandling();
            LINQQueries();
            GenericsExample();

            // === ADVANCED ===
            DelegatesAndEvents();
            LambdasAndAnonymousMethods();
            AsyncAwaitExample();

            Console.WriteLine("\n--- End of Anatomy of C# demo ---");
        }

        // =========================
        // BASIC CONCEPTS
        // =========================
        static void VariablesAndDataTypes()
        {
            // C# is strongly typed: every variable has a type
            int age = 25;
            double price = 19.99;
            bool isActive = true;
            char grade = 'A';

            Console.WriteLine($"Age: {age}, Price: {price}, Active: {isActive}, Grade: {grade}");
        }

        static void StringsAndInterpolation()
        {
            string name = "John";
            int score = 90;

            // String interpolation
            Console.WriteLine($"Hello {name}, your score is {score}");

            // String methods
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.Replace("John", "Jane"));
        }

        static void Conditionals()
        {
            int number = 15;
            if (number > 10)
            {
                Console.WriteLine("Number is greater than 10");
            }
            else
            {
                Console.WriteLine("Number is 10 or less");
            }
        }

        static void Loops()
        {
            // For loop
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"For loop iteration {i}");
            }

            // Foreach loop
            foreach (var color in new string[] { "Red", "Green", "Blue" })
            {
                Console.WriteLine($"Color: {color}");
            }
        }

        static void ArraysAndLists()
        {
            int[] numbers = { 1, 2, 3 };
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

            Console.WriteLine("First number: " + numbers[0]);
            fruits.Add("Mango");
            Console.WriteLine($"Fruit count: {fruits.Count}");
        }

        // =========================
        // OOP CONCEPTS
        // =========================
        static void ClassesAndObjects()
        {
            Person p = new Person("Alice", 30);
            p.Introduce();
        }

        static void InheritanceAndPolymorphism()
        {
            Animal myDog = new Dog();
            myDog.Speak();
        }

        static void InterfacesAndAbstraction()
        {
            IVehicle car = new Car();
            car.Drive();
        }

        // =========================
        // INTERMEDIATE CONCEPTS
        // =========================
        static void ExceptionHandling()
        {
            try
            {
                int x = 10;
                int y = 0;
                int result = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void LINQQueries()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var evens = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("Even numbers: " + string.Join(", ", evens));
        }

        static void GenericsExample()
        {
            GenericBox<int> intBox = new GenericBox<int>(42);
            Console.WriteLine("Generic box contains: " + intBox.Value);
        }

        // =========================
        // ADVANCED CONCEPTS
        // =========================
        static void DelegatesAndEvents()
        {
            MyDelegate del = message => Console.WriteLine("Delegate says: " + message);
            del("Hello from delegate!");
        }

        static void LambdasAndAnonymousMethods()
        {
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine("Lambda sum: " + add(3, 4));
        }

        static async void AsyncAwaitExample()
        {
            Console.WriteLine("Starting async task...");
            await Task.Delay(1000);
            Console.WriteLine("Async task completed!");
        }
    }

    // ====== SUPPORTING CLASSES ======
    class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, and I'm {Age} years old.");
        }
    }

    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    interface IVehicle
    {
        void Drive();
    }

    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving...");
        }
    }

    // ====== GENERICS ======
    class GenericBox<T>
    {
        public T Value { get; }
        public GenericBox(T value) => Value = value;
    }

    // ====== DELEGATES ======
    delegate void MyDelegate(string message);
}