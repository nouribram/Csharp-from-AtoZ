/*
 
   Loops in C#
  Loops allow you to execute a block of code multiple times. 
  C# provides several types of loops: for, while, do-while, and foreach.
*/

using System;

namespace CSharpTutorial
{
    class Loops
    {
        static void Main(string[] args)
        {
            /*
              FOR LOOP
              Used when the number of iterations is known.
              Syntax: for(initialization; condition; update)
            */
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("For Loop iteration: " + i);
            }

            Console.WriteLine("-----------------------------");

            /*
              WHILE LOOP
              Executes a block of code as long as the condition is true.
              The condition is checked before each iteration.
            */
            int count = 1;
            while (count <= 3)
            {
                Console.WriteLine("While Loop count: " + count);
                count++;
            }

            Console.WriteLine("-----------------------------");

            /*
              DO-WHILE LOOP
              Similar to while, but guarantees the loop runs at least once.
              The condition is checked after each iteration.
            */
            int num = 1;
            do
            {
                Console.WriteLine("Do-While Loop number: " + num);
                num++;
            } while (num <= 2);

            Console.WriteLine("-----------------------------");

            /*
              FOREACH LOOP
              Used to iterate through elements in a collection (like an array or list).
            */
            string[] fruits = { "Apple", "Banana", "Mango" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit: " + fruit);
            }

            Console.WriteLine("-----------------------------");

            /*
              LOOP CONTROL STATEMENTS
              - break: exits the loop immediately
              - continue: skips the current iteration and moves to the next
            */
            for (int j = 1; j <= 5; j++)
            {
                if (j == 3)
                {
                    Console.WriteLine("Skipping number 3 using 'continue'");
                    continue;
                }

                if (j == 5)
                {
                    Console.WriteLine("Breaking at number 5 using 'break'");
                    break;
                }

                Console.WriteLine("Current number: " + j);
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("All loops executed successfully!");
        }
    }
}
