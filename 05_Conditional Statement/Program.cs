/**
 C# Tutorial: Conditional Statements
*/

/**
 Conditional statements allow your program to make decisions
 and execute different code paths depending on conditions.

 C# provides several conditional constructs:
 - if / else if / else
 - switch
 - ternary operator (?:)
 - pattern matching in switch expressions
*/

/**
 1. if Statement
*/

/**
 The if statement tests a condition.
 If the condition is true, the code inside runs.

 Example:

 int age = 20;

 if (age >= 18)
 {
     Console.WriteLine("You are an adult.");
 }

 Output: You are an adult.
*/

/**
 2. if...else Statement
*/

/**
 The else block runs if the condition is false.

 Example:

 int age = 15;

 if (age >= 18)
 {
     Console.WriteLine("You are an adult.");
 }
 else
 {
     Console.WriteLine("You are a minor.");
 }

 Output: You are a minor.
*/

/**
 3. if...else if...else Statement
*/

/**
 You can chain multiple conditions using else if.

 Example:

 int score = 85;

 if (score >= 90)
 {
     Console.WriteLine("Grade: A");
 }
 else if (score >= 80)
 {
     Console.WriteLine("Grade: B");
 }
 else if (score >= 70)
 {
     Console.WriteLine("Grade: C");
 }
 else
 {
     Console.WriteLine("Grade: F");
 }

 Output: Grade: B
*/

/**
 4. Nested if Statements
*/

/**
 You can place an if statement inside another.

 Example:

 bool isLoggedIn = true;
 bool isAdmin = false;

 if (isLoggedIn)
 {
     if (isAdmin)
     {
         Console.WriteLine("Welcome, Admin!");
     }
     else
     {
         Console.WriteLine("Welcome, User!");
     }
 }

 Output: Welcome, User!
*/

/**
 5. switch Statement
*/

/**
 The switch statement is used for multiple possible values.

 Example:

 string day = "Monday";

 switch (day)
 {
     case "Monday":
         Console.WriteLine("Start of the week!");
         break;
     case "Friday":
         Console.WriteLine("Weekend is near!");
         break;
     case "Sunday":
         Console.WriteLine("Rest day!");
         break;
     default:
         Console.WriteLine("Just another day.");
         break;
 }

 Output: Start of the week!
*/

/**
 6. switch Expressions (C# 8+)
*/

/**
 A modern, compact way to handle conditions using expressions.

 Example:

 string mood = "happy";

 string message = mood switch
 {
     "happy" => "Keep smiling!",
     "sad" => "Cheer up!",
     "angry" => "Take a deep breath.",
     _ => "Unknown mood."
 };

 Console.WriteLine(message);

 Output: Keep smiling!
*/

/**
 7. Ternary Operator (?:)
*/

/**
 A shorthand for simple if-else statements.

 Syntax:
 condition ? value_if_true : value_if_false

 Example:

 int age = 21;
 string status = age >= 18 ? "Adult" : "Minor";
 Console.WriteLine(status);

 Output: Adult
*/

/**
 8. Logical Operators
*/

/**
 Combine conditions using logical operators:
 - && (AND)
 - || (OR)
 - ! (NOT)

 Example:

 bool hasKey = true;
 bool hasPassword = false;

 if (hasKey && hasPassword)
 {
     Console.WriteLine("Access granted.");
 }
 else
 {
     Console.WriteLine("Access denied.");
 }

 Output: Access denied.
*/

/**
 9. Pattern Matching in Conditions (C# 7+)
*/

/**
 C# allows pattern-based conditions for cleaner code.

 Example:

 object input = 42;

 if (input is int number && number > 0)
 {
     Console.WriteLine($"Positive integer: {number}");
 }

 Output: Positive integer: 42
*/

/**
 10. Summary
*/

/**
 Conditional statements control the flow of logic in your program.

 Key points:
 - Use if/else for basic decisions.
 - Use switch for multiple discrete values.
 - Use ternary for short, inline decisions.
 - Use logical operators to combine conditions.
 - Modern C# supports expressive switch expressions and pattern matching.

 Conditional logic is fundamental to writing interactive and responsive applications.
*/
