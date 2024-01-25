/*Author: Magaly Rodriguez
 * Course: COMP-003A
 * Purpose: Lecture activity for variables, type system, math, and console properties
 * Reference: The C# player's guide by RB Whitaker
 * */

using System.Runtime.InteropServices;

namespace COMP003A.lectureactivity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Working with variables
            //the following code shows all three primary variable-related activities:
            string username; //declaring a variable (1 of 3)
            Console.WriteLine("What is your name?"); //request for user input
            username = Console.ReadLine(); //assigning a value to a variable (2 of 3)
            Console.WriteLine("Hi " + username); // retrieving its current value (3 of 3)

            //another example of the three primary variable related activities (declaring, assigning, and retrieving)
            string favoriteColor;
            Console.WriteLine("What is your favorite color?");
            favoriteColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + favoriteColor);

            //working with variable integers
            int score; //declare a new variable with a data type int
            //score = "generic user"; will fail to compile because the "0" is still assigned as a string - enclosed in the double quotes
            score = 0; //works
            score = 4; //you can reassign values to the variable as long as they are within scope and not constant
            score = 11;
            score = -1564;

            //reading from a variable does not change it
            int a;
            int b;

            a = 5;
            b = 2;
            Console.WriteLine("The current value of a: " + a);
            Console.WriteLine("The current value of b: " + b);

            b = a;
            a = -3;
            Console.WriteLine("The new value of a: " + a);
            Console.WriteLine("The new value of b: " + b);

            //variable are case sensitive. the variables below are different despite having similar names
            string exampleVariable;
            string exampleVAriable;
            string exampleVARiable;

            Console.WriteLine("*********************************************");

            /*types of variables and values matter in C# and are not interchangeable.
             * there are eight integer types for storing integers of differing sizes and ranges:
             * int, short, long, byte, sbyte, uint, ushort, and ulong. 
             * the char type stores single characters.
             * the string type stores longer text. 
             * there are three types for storing real numbers: float, double, and decimal.
             * the bool type stores truth values (true and false) used in logic.
             * these types are the building blocks of a much larger type system.
             * using var for a variable's type tells the compiler to infer its type from the surrounding code,
             * so you do not have to type it out. (but it is still a specific type.)
             * the System.Convert class is a useful class to convert from one type to another.
             */

            //declaring and using variables with integer types
            byte aSingleByte = 34;
            Console.WriteLine("aSingleByte: " + aSingleByte);
            aSingleByte = 17;
            Console.WriteLine("aSingleByte: " + aSingleByte);

            short aNumber = 5039;
            Console.WriteLine("aNumber: " + aNumber);
            aNumber = -4354;
            Console.WriteLine("aNumber: " + aNumber);

            long aVeryBigNumber = 395904282569;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
            aVeryBigNumber = 13;
            Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);

            int anInteger = 2147483647;

            //declaring, using, and concatenating (so linking things together in a chain) characters and strings 
            char aLetter = 'A'; //character values are enclosed in single quotes
            string message = "Hello World!"; //string values are enclosed in double quotes

            Console.WriteLine("Concatenation using + :" + aLetter + " " + message);
            //use the plus (+) sign in between characters/strings to concatenate (link)
            Console.WriteLine($"Concatenation using string enterpolation : {aLetter} {message} ");
            //use string interpolation with a dollar-sign ($) before the opening double quote and enclosing variables with curly braces ({variableName)}

            //floating-point types
            double number1 = 3.5623;
            float number2 = 3.5623f;
            decimal number3 = 3.5623m;
            Console.WriteLine($"Value of number1: {number1}");
            Console.WriteLine($"Value of number2: {number2}");
            Console.WriteLine($"Value of number3: {number3}");

            //scientific notation
            double avogadrosNumber = 6.022e23;
            Console.WriteLine($"Value of avogadrosNumber: {avogadrosNumber}");

            //bool type
            bool itWorked = true;
            Console.WriteLine($"Value of itWorked: {itWorked}");
            itWorked = false;
            Console.WriteLine($"New value of itWorked: {itWorked}");

            //convert
            string inputAgeString;
            int inputAge;
            int currentYear = 2023;
            Console.WriteLine($"Enter age in {currentYear}: ");
            inputAgeString = Console.ReadLine();
            inputAge = Convert.ToInt32(inputAgeString);
            Console.WriteLine($"Your age is {inputAge}");

            Console.WriteLine("************************************************************");

            /* 
             * math operations
             * addition : +
             * subtraction: -
             * multiplication: * 
             * division: / 
             * modulo: % (remainder)
             */

            int addition = 2 + 3;
            int subtraction = 5 - 2;
            int multiplication = 22 * 2;
            int division = 21 / 7;
            int modulo = 77 % 5;
            Console.WriteLine($"Value of addition: {addition}");
            Console.WriteLine($"Value of subtraction: {subtraction}");
            Console.WriteLine($"Value of multiplication: {multiplication}");
            Console.WriteLine($"Value of division: {division}");
            Console.WriteLine($"Value of modulo: {modulo}");

            /*arithmetic, compound expressions and order of operations
             * multiplication and division are done first, left to right
             * addition and subtraction left last, left to right
             * reference https://csharpplayersguide.com/articles/operators-table
             */

            int arithmetic1; //declaring the variable arithmetic1
            arithmetic1 = 9 - 2; // assigning a vlaue to arithmetic1 using math
            Console.WriteLine($"Value of arithmetic1: {arithmetic1}");
            arithmetic1 = 3 + 3; //another assignment
            Console.WriteLine($"New Value of arithmetic1: {arithmetic1}");
            int arithmetic2 = 3 + 1; //declaring arithmetic2 and assigning value to it all at once
            Console .WriteLine($"Value of arithmetic2: {arithmetic2}");
            arithmetic2 = 1 + 2; //assigning a second value to arithmetic2
            Console .WriteLine($"New value of arithmetic2: {arithmetic2}");

            //use multiple sets of parentheses to group operations
            int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
            Console.WriteLine($"Value of result: {result}");








        }
    }
}
