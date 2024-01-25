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
            string username; //declaring a variable (1 0f 3)
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
        }


    }
}
