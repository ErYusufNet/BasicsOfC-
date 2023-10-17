using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Symbol for the OR operator: ||
            // It returns true if at least one of the conditions is true.

            // Declare three integer variables 'number1', 'number2', and 'number3'.
            int number1 = 3;    
            int number2 = 3;
            int number3 = 5;

            // Use the '||' operator to check two conditions:
            // Condition 1: Is 'number1' equal to 'number2'?
            // Condition 2: Is 'number2' greater than 'number3'?
            // If at least one of these conditions is true, 'isTrue' will be true.
            bool isTrue = (number1 == number2) || (number2 > number3);

            // Print the result of the logical OR operation.
            Console.WriteLine("Result of logical OR operation: " + isTrue);
        }
    }
}
