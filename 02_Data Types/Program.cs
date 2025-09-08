//  C# data types 

using System;

namespace CSharpLearning
{
    class CSharpDataTypes
    {
        static void Main(string[] args)
        {
            // -----------------------
            // VALUE TYPES (store data directly)
            // -----------------------
            
            // Integers
            int age = 25;                 // -2,147,483,648 to 2,147,483,647
            long bigNumber = 9876543210;  // Very large integers
            byte smallNumber = 255;       // 0-255
            short shortNumber = 32000;    // -32,768 to 32,767
            
            // Decimal types
            float temperature = 36.6f;     // ~7-digit precision 
            double pi = 3.14159265359;    // 15-16 digit precision
            decimal price = 19.99m;       // 28-29 digit precision for money 
            
            // Other value types
            bool isActive = true;          // true / false
            char grade = 'A';              // single character
            Day today = Day.Mon;           // enum example

            // -----------------------
            // REFERENCE TYPES (store memory address)
            // -----------------------
            
            string name = "Ibrahim";          // Text
            int[] numbers = {1,2,3};       // Array
            object obj = 42;               // Base type for all types
            dynamic something = "Hello";   // Type decided at runtime

            // -----------------------
            // NULLABLE TYPE
            // -----------------------
            int? nullableAge = null;       // Can store a number or null

            // -----------------------
            // Type conversion examples
            // -----------------------
            double converted = age;        // Implicit conversion (safe)
            int rounded = (int)pi;         // Explicit conversion (casting)

            // -----------------------
            // Output examples
            // -----------------------
            Console.WriteLine($"Name: {name}, Age: {age}, Price: {price}, Active: {isActive}");
        }

        // Enum example
        enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun }
    }
}
