using System;

namespace ConditionalStatementsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================================
            // Introduction to Conditional Statements
            // ================================
            Console.WriteLine("Slide 1: Introduction to Conditional Statements");
            int age = 18;
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            Console.WriteLine();

            // ================================
            // Slide 2 – The if Statement
            // ================================
            Console.WriteLine(" The if Statement");
            int num1 = 10;
            if (num1 > 5)
            {
                Console.WriteLine("Number is greater than 5.");
            }
            Console.WriteLine();

            // ================================
            // The if-else Statement
            // ================================
            Console.WriteLine("Slide 3: The if-else Statement");
            int num2 = 3;
            if (num2 % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
            Console.WriteLine();

            // ================================
            // The else if Ladder
            // ================================
            Console.WriteLine("Slide 4: Using else if for Multiple Conditions");
            int marks = 85;
            if (marks >= 90)
                Console.WriteLine("Grade A");
            else if (marks >= 75)
                Console.WriteLine("Grade B");
            else
                Console.WriteLine("Grade C");
            Console.WriteLine();

            // ================================
            // The switch Statement
            // ================================
            Console.WriteLine("Slide 5: The switch Statement");
            int day = 3;
            switch (day)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                default: Console.WriteLine("Other day"); break;
            }
            Console.WriteLine();

            // ================================
            //  Nested Conditional Statements
            // ================================
            Console.WriteLine("Slide 6: Nested Conditional Statements");
            int num3 = 20;
            if (num3 > 0)
            {
                if (num3 % 2 == 0)
                    Console.WriteLine("Positive even number");
                else
                    Console.WriteLine("Positive odd number");
            }
            else
            {
                Console.WriteLine("Number is zero or negative");
            }
            Console.WriteLine();

            // ================================
            // – Ternary Operator
            // ================================
            Console.WriteLine("Slide 7: Ternary Operator");
            int age2 = 20;
            string type = (age2 >= 18) ? "Adult" : "Minor";
            Console.WriteLine(type);
        }
    }
}
