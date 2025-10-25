/**
 C# Comments & Code Formatting
*/

/**
 Writing clear comments and using consistent formatting
 helps make your code easy to understand, maintain, and review.
*/

/**
 1. Why Comments Matter
*/

/**
 Comments explain *why* something exists,
 not just *what* it does.

 Example (bad comment):
 // Increment i by 1
 i++;

 Example (good comment):
 // Move to the next record in the list
 i++;
*/

/**
 Use comments to:
 - Explain intent behind logic
 - Clarify complex algorithms
 - Provide context for future developers
 - Mark TODOs or known issues
*/

/**
 Avoid comments that:
 - Repeat what code already says
 - Describe obvious logic
 - Become outdated or misleading
*/

/**
 2. Types of Comments in C#
*/

/**
 Single-line comment:
 // This is a single-line comment

 Multi-line comment:
 /*
   This is a multi-line comment
   It can span multiple lines
 * /

 XML documentation comment (for public members):
 /// <summary>
 /// Adds two numbers and returns the result
 /// </summary>
 public int Add(int a, int b)
 {
     return a + b;
 }
 
 XML comments are used by IntelliSense and documentation tools.
*/

/**
 3. XML Documentation Tags
*/

/**
 Common XML comment tags:
 - <summary> → Describes purpose of method/class
 - <param> → Describes a method parameter
 - <returns> → Describes return value
 - <remarks> → Adds extra info
 - <example> → Provides a usage example

 Example:

 /// <summary>
 /// Calculates the area of a rectangle.
 /// </summary>
 /// <param name="width">The width of the rectangle.</param>
 /// <param name="height">The height of the rectangle.</param>
 /// <returns>The computed area.</returns>
 public double CalculateArea(double width, double height)
 {
     return width * height;
 }
*/

/**
 4. Code Formatting Best Practices
*/

/**
 Follow consistent formatting conventions to make code easy to read.

 Basic rules:
 - Use 4 spaces for indentation (not tabs)
 - Keep line length under ~100 characters
 - Add spaces around operators and after commas
 - Keep methods small and focused
 - Use PascalCase for class and method names
 - Use camelCase for local variables and parameters
*/

/**
 Example (good formatting):

 public class Calculator
 {
     public double Add(double a, double b)
     {
         return a + b;
     }

     public double Multiply(double a, double b)
     {
         return a * b;
     }
 }
 
 Example (bad formatting):

 public class calculator{public double add(
