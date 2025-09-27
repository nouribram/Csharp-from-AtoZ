/*
==========================================
Arrays in C# 
==========================================
*/

using System;

class ArraysTutorial
{
    static void Main()
    {
        // Introduction to Arrays
        // An array stores multiple values of the SAME type in a single variable.
        // Indexing starts from 0.

        int[] numbers = new int[4]; // Array of size 4 (default values = 0)

        // Declaring & Initializing Arrays
        string[] names = { "Ali", "Sara", "Omar" }; // Direct initialization
        int[] ages = new int[3]; // Declare with size
        ages[0] = 20; // Assign values individually
        ages[1] = 25;
        ages[2] = 30;

        // Accessing Array Elements
        Console.WriteLine("First name: " + names[0]); // Output: Ali
        Console.WriteLine("Second age: " + ages[1]);  // Output: 25

        // Iterating Through Arrays
        Console.WriteLine("\n--- Iterating with for loop ---");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"Index {i}: {names[i]}");
        }

        Console.WriteLine("\n--- Iterating with foreach ---");
        foreach (string n in names)
        {
            Console.WriteLine(n);
        }

        //Common Properties & Methods
        int[] scores = { 88, 55, 99, 70 };
        Console.WriteLine("\nArray Length: " + scores.Length); // Number of elements

        Array.Sort(scores); // Sort ascending
        Console.WriteLine("Sorted: " + string.Join(", ", scores));

        Array.Reverse(scores); // Reverse order
        Console.WriteLine("Reversed: " + string.Join(", ", scores));

        // Multidimensional Arrays
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6}
        };
        Console.WriteLine("\nMultidimensional Array Example:");
        Console.WriteLine(matrix[1, 2]); // Output: 6

        // Jagged Arrays (array of arrays)
        int[][] jagged = new int[2][];
        jagged[0] = new int[] { 1, 2, 3 };
        jagged[1] = new int[] { 4, 5 };

        Console.WriteLine("\nJagged Array Example:");
        Console.WriteLine(jagged[1][0]); // Output: 4
    }
}
