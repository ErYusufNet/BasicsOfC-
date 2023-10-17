using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEqualOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Not equal operator: !=

            // Declare two integer variables, 'number1' and 'number2', and assign them values.
            int number1 = 5;
            int number2 = 7;

            // Use the not equal operator '!=' to compare 'number1' and 'number2'.
            // The '!=' operator checks if the values are not equal and returns 'true' if they are different.
            bool control = number1 != number2;

            // Print the result of the comparison to the console.
            Console.WriteLine(control);
        }
    }
}
