using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The '&&' operator is the logical AND operator.

            // Declare three integer variables 'number1', 'number2', and 'number3'.
            int number1 = 5;
            int number2 = 5;
            int number3 = 10;

            // Use the '&&' operator to check if 'number1' is equal to 'number2' AND 'number1' is less than 'number3'.
            // Store the result in the 'isTrue' variable.
            bool isTrue = (number1 == number2) && (number1 < number3);

            // Print the result of the logical AND operation.
            Console.WriteLine("Result of logical AND operation: " + isTrue);
        }
    }
}
