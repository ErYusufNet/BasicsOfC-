using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Equality operator: ==

            // Declare two integer variables, 'number1' and 'number2', and assign them values.
            int number1 = 5;
            int number2 = 5;

            // Use the equality operator '==' to compare 'number1' and 'number2'.
            // The '==' operator checks if the values are equal and returns 'true' if they are.
            bool control = number1 == number2;

            // Print the result of the comparison to the console.
            Console.WriteLine(control);
        }
    }
}
