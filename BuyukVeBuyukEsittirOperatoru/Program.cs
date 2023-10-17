using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterThanOrEqualOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Greater than operator: >
            // Greater than or equal to operator: >=

            // Declare an integer variable 'number1' and initialize it with the value 30.
            int number1 = 30;

            // Use the greater than or equal to operator (>=) to compare 'number1' with 30.
            // Store the result (true or false) in the boolean variable 'control'.
            bool control = number1 >= 30;

            // Print the result of the comparison to the console.
            Console.WriteLine(control);
            /*
             In this C# program, we explore the greater than or equal to (>=) operator. Here's a detailed explanation:

            We declare and initialize an integer variable named number1 with the value 30.

            We use the greater than or equal to operator (>=) to compare the value of number1 with 30. 
            The result of this comparison, either true or false, is stored in the boolean variable control.

            Finally, we print the result of the comparison to the console, which will be either true or false in this case.

            This program demonstrates the use of the greater than or equal to operator in C# to compare values
            and determine whether one value is greater than or equal to another. It prints the result of the
            comparison to the console.
             */
        }
    }
}
