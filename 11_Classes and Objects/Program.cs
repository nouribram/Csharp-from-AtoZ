/*
  Topic: C# Classes and Objects
  In C#, **classes** are blueprints for creating **objects**.
  A class defines the properties (data) and methods (behavior) that objects will have.

  An **object** is an instance of a class — created using the `new` keyword.

  Class = Template  
  Object = Instance of that template
*/

using System;

namespace ClassesAndObjectsDemo
{
    // Define a Class
    public class Person
    {
        // Fields (Data)
        public string Name;
        public int Age;

        // Constructor (Runs when an object is created)
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method (Behavior)
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {Age} years old.");
        }

        // Method with return value
        public int GetBirthYear()
        {
            return DateTime.Now.Year - Age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Objects from the Person class
            Person person1 = new Person("Alice", 25);
            Person person2 = new Person("Bob", 30);

            // Call methods on objects
            person1.Introduce();
            person2.Introduce();

            Console.WriteLine($"{person1.Name} was born in {person1.GetBirthYear()}.");
            Console.WriteLine($"{person2.Name} was born in {person2.GetBirthYear()}.");
        }
    }
}

/*
  Key Points:
  - Class → Defines structure and behavior.
  - Object → Instance of a class.
  - Constructor → Special method that initializes objects.
  - Fields → Variables that store object data.
  - Methods → Functions that define object actions.

    Example Summary:
  - Person class defines data (Name, Age) and actions (Introduce, GetBirthYear).
  - Each new Person() creates a separate object with its own data.
*/
