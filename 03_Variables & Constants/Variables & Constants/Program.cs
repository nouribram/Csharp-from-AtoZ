using System;

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // ======================================================
            // Introduction to Variables
            // Variables are named storage locations in memory.
            // They have a type and can store data that can change.
            int age = 25;
            string name = "Ibrahim";
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Name: " + name);

            // ======================================================
            // Variable Naming Rules
            // 1. Must start with a letter or underscore
            // 2. Cannot start with a number or contain spaces
            // 3. Case-sensitive
            // 4. Cannot be a C# keyword
            int score;       // valid
            string _userName = "Ibrahim";  // valid
            bool isActive = true;       // valid
            // int 1stScore; // invalid
            // string user name; // invalid

            // ======================================================
            // Variable Types
            // Value types store actual data: int, float, double, bool, char
            int height = 180;
            double weight = 72.5;
            bool isStudent = false;
            char grade = 'A';

            // Reference types store references: string, arrays, objects
            string city = "Saint";

            // Type inference using 'var'
            var country = "Russia"; // compiler infers string
            var year = 2027;       // compiler infers int

            // ======================================================
            // Declaration & Initialization
            int level;      // declaration
            level = 5;      // initialization
            int points = 100; // declaration + initialization

            // ======================================================
            //  Constants
            // Constants cannot change after declaration
            const double Pi = 3.14159;
            const string Country = "Russia";
            Console.WriteLine("Pi: " + Pi);
            Console.WriteLine("Country: " + Country);

            // ======================================================
            // Readonly Variables
            // Readonly values can be assigned once in declaration or constructor
            MyClass myClass = new MyClass();
            Console.WriteLine("Max Users: " + myClass.MaxUsers);

            // ======================================================
            // Summary & Best Practices
            // - Use meaningful variable names
            // - Use constants for fixed values
            // - Initialize variables before use
            // Summary table example is explained in comments above
        }
    }

    class MyClass
    {
        // Readonly variable
        public readonly int MaxUsers;

        public MyClass()
        {
            MaxUsers = 100; // can assign only here or at declaration
        }
    }
}
