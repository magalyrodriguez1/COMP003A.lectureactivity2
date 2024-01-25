/*Author: Magaly Rodriguez
 * Course: COMP-003A
 * Purpose: Lecture activity for variables, type system, math, and console properties
 * Reference: The C# player's guide by RB Whitaker
 * */

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
            Console.WriteLine("Hi" + username); // retrieving its current value (3 of 3)
        }


    }
}
