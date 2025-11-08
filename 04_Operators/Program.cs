using System;

namespace CSharpOperatorsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // ======================================================
            // Introduction to Operators
            // Operators are symbols used to perform operations on variables and values.
            // We will cover Arithmetic, Comparison, and Logical operators.
            int a = 10, b = 5;
            Console.WriteLine("Arithmetic example: " + (a + b)); // 15

            // ======================================================
            //  Arithmetic Operators
            // + : Addition
            // - : Subtraction
            // * : Multiplication
            // / : Division
            // % : Modulus (remainder)
            int x = 10, y = 3;
            Console.WriteLine("x + y = " + (x + y)); // 13
            Console.WriteLine("x - y = " + (x - y)); // 7
            Console.WriteLine("x * y = " + (x * y)); // 30
            Console.WriteLine("x / y = " + (x / y)); // 3
            Console.WriteLine("x % y = " + (x % y)); // 1

            // ======================================================
            // Increment & Decrement
            // ++ increases a value by 1
            // -- decreases a value by 1
            // Pre-increment (++n): increase first, then use
            // Post-increment (n++): use first, then increase
            int n = 5;
            Console.WriteLine("++n = " + (++n)); // 6
            Console.WriteLine("n++ = " + (n++)); // 6 (then n becomes 7)
            Console.WriteLine("n = " + n);       // 7

            // ======================================================
            //  Comparison Operators
            // == : Equal to
            // != : Not equal to
            // >  : Greater than
            // <  : Less than
            // >= : Greater or equal
            // <= : Less or equal
            int c = 10, d = 20;
            Console.WriteLine("c < d: " + (c < d));   // true
            Console.WriteLine("c == d: " + (c == d)); // false
            Console.WriteLine("c != d: " + (c != d)); // true

            // ======================================================
            //  Logical Operators
            // && : AND → true only if both conditions are true
            // || : OR  → true if at least one condition is true
            // !  : NOT → reverses the result
            bool isAdult = true, hasTicket = false;
            Console.WriteLine("isAdult && hasTicket: " + (isAdult && hasTicket)); // false
            Console.WriteLine("isAdult || hasTicket: " + (isAdult || hasTicket)); // true
            Console.WriteLine("!isAdult: " + (!isAdult)); // false

            // ======================================================
            // Using Operators in Conditions
            int age = 20;
            bool hasID = true;
            if (age >= 18 && hasID)
            {
                Console.WriteLine("Access granted");
            }
            else
            {
                Console.WriteLine("Access denied");
            }

            // ======================================================
            //  Summary & Best Practices
            // - Arithmetic: +, -, *, /, %
            // - Increment/Decrement: ++, --
            // - Comparison: ==, !=, <, >, <=, >=
            // - Logical: &&, ||, !
            // Best Practices:
            // - Use parentheses () for clarity
            // - Avoid dividing by zero
            // - Keep conditions simple and readable
            int num1 = 8, num2 = 4;
            Console.WriteLine("Summary demo: " + ((num1 > num2) && (num1 % num2 == 0))); // true
        }
    }
}
