using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program demonstrates basic addition and subtraction operations.

            // Declare two integer variables 'number1' and 'number2' and calculate their sum.
            int number1 = 5;
            int number2 = 10;
            int result = number1 + number2;

            // Declare two more integer variables 'number3' and 'number4' and calculate their difference.
            int number3 = 50;
            int number4 = 30;
            int result2 = number3 - number4;

            // Print the sum and difference results to the console.
            Console.WriteLine("Sum of number1 and number2: " + result);
            Console.WriteLine("Difference of number3 and number4: " + result2);
        }
    }
}
