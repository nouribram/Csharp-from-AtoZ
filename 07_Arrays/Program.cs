/*
 
  Arrays in C#
  Arrays are used to store multiple values of the same type in a single variable.
  Each element in an array is accessed using an index (starting from 0).
*/

using System;

namespace CSharpTutorial
{
    class Arrays
    {
        static void Main(string[] args)
        {
            /*
              SINGLE-DIMENSIONAL ARRAY
              Declaration and Initialization
            */
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Single-Dimensional Array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Index " + i + ": " + numbers[i]);
            }

            Console.WriteLine("-----------------------------");

            /*
              MODIFYING ARRAY ELEMENTS
            */
            numbers[2] = 99; // Change value at index 2
            Console.WriteLine("After modification, numbers[2] = " + numbers[2]);

            Console.WriteLine("-----------------------------");

            /*
              USING FOREACH LOOP TO PRINT ARRAY
            */
            Console.WriteLine("Printing array using foreach:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("-----------------------------");

            /*
              MULTI-DIMENSIONAL ARRAY
              Example: 2D array (matrix)
            */
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Two-Dimensional Array (Matrix):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");

            /*
              JAGGED ARRAY (ARRAY OF ARRAYS)
              Each row can have different lengths.
            */
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6 };

            Console.WriteLine("Jagged Array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");

            /*
              ARRAY METHODS
              Commonly used static methods from System.Array class.
            */
            int[] arr = { 5, 3, 9, 1, 4 };
            Array.Sort(arr); // Sorts array
            Console.WriteLine("Sorted Array: " + string.Join(", ", arr));

            Array.Reverse(arr); // Reverses array order
            Console.WriteLine("Reversed Array: " + string.Join(", ", arr));

            int index = Array.IndexOf(arr, 9); // Finds index of a value
            Console.WriteLine("Index of 9: " + index);

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Array demonstration complete!");
        }
    }
}
