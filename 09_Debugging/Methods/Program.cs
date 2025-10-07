/**
====================================================
 C# Methods 
====================================================

 Introduction to Methods
--------------------------------
- A method is a block of code designed to perform a specific task.
- Benefits:
  • Reduce code duplication
  • Improve readability and modularity
- Syntax:
    returnType MethodName(parameters)
    {
        // statements
        return value; // if not void
    }
- Example:
    void Greet()
    {
        Console.WriteLine("Welcome to C#");
    }

----------------------------------------------------

 Components of a Method
--------------------------------
1. Return Type → Data type of the value returned. If no return → use void.
2. Method Name → Unique identifier, describes the task.
3. Parameters (Optional) → Inputs for the method.
4. Method Body → Code statements to execute.
5. Return Statement → Ends method and sends value back.

Example:
    int Add(int x, int y)
    {
        return x + y;
    }

----------------------------------------------------

 Types of Methods
--------------------------
1. Void Methods → No return value.
2. Value-Returning Methods → Return a result.
3. Static Methods → Belong to class itself, called without object.
4. Instance Methods → Belong to object, need instance to call.

Examples:
    void PrintMessage() { Console.WriteLine("Hello!"); }
    double Square(double n) { return n * n; }
    static void Info() { Console.WriteLine("Static Method"); }



----------------------------------------------------

 Parameters in Methods
-------------------------------
- Value Parameter (default): Passes copy, original not affected.
- ref Parameter: Passes by reference, allows modification.
- out Parameter: Must assign value inside method.
- params Parameter: Variable number of arguments.

Example:
    void Display(params int[] numbers)
    {
        foreach (int n in numbers)
            Console.WriteLine(n);
    }




----------------------------------------------------

 Method Overloading
----------------------------
- Same method name, different parameter lists.
- Based on number, type, or order of parameters.
- Improves code readability.

Example:
    int Multiply(int a, int b) => a * b;
    double Multiply(double a, double b) => a * b;
    string Multiply(string s, int n) => string.Concat(Enumerable.Repeat(s, n));

----------------------------------------------------

 Access Modifiers in Methods
-------------------------------------
- public → Accessible from anywhere.
- private → Only inside same class.
- protected → Inside class and derived classes.
- internal → Inside same assembly only.
- protected internal → Same assembly or derived class.
- private protected → Containing class or derived in same assembly.

----------------------------------------------------

 Best Practices for Methods
------------------------------------
- Keep methods small and focused (Single Responsibility).
- Use meaningful names (e.g., CalculateTotal).
- Avoid too many parameters (use objects if needed).
- Prefer returning values over changing globals.
- Write reusable, testable methods.
- Use XML documentation for clarity:
    /// <summary>
    /// Calculates area of rectangle
    /// </summary>
    int Area(int l, int w) => l * w;

====================================================
**/

using System;
using System.Linq;

public class MethodsDemo
{
    static void Greet()
    {
        Console.WriteLine("Welcome to C#");
    }

   
    static int Add(int x, int y)
    {
        return x + y;
    }

    
    static void PrintMessage()
    {
        Console.WriteLine("Hello!");
    }

    static double Square(double n)
    {
        return n * n;
    }

  

    static void Display(params int[] numbers)
    {
        foreach (int n in numbers)
            Console.WriteLine(n);
    }

    static int Multiply(int a, int b) => a * b;
    static double Multiply(double a, double b) => a * b;
    static string Multiply(string s, int n) => string.Concat(Enumerable.Repeat(s, n));

  
    /// Calculates area of a rectangle
    static int Area(int length, int width) => length * width;

    // Main method to test
    public static void Main()
    {
        Greet();
        Console.WriteLine("Add: " + Add(3, 5));
        PrintMessage();
        Console.WriteLine("Square: " + Square(4));
        Info();
        Display(1, 2, 3, 4);
        Console.WriteLine("Multiply int: " + Multiply(2, 3));
        Console.WriteLine("Multiply double: " + Multiply(2.5, 3.5));
        Console.WriteLine("Multiply string: " + Multiply("Hi", 3));
        Console.WriteLine("Area: " + Area(5, 6));
    }
}
