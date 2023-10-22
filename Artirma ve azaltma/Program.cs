using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementAndDecrement
{
    internal class Program

    {
        static void Main(string[] args)
        {
            // Declare and initialize two integer variables.
            int number1 = 20;
            int number2 = 30;

            // Increment 'number1' by 1.
            number1++;

            // Decrement 'number2' by 1.
            number2--;

            // Print the updated values of the variables.
            Console.WriteLine("Value of 'number1' after incrementing: " + number1);
            Console.WriteLine("Value of 'number2' after decrementing: " + number2);
        }
    }
}
