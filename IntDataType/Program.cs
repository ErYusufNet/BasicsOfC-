using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             The int data type can hold values between -2,147,483,648 and 2,147,483,647.
             It occupies 4 bytes of memory and can represent integers with up to 10 digits.
             */

            // Declare an integer variable 'mynumber' and initialize it with a negative value.
            int mynumber = -223132;

            // Declare another integer variable 'mynumber2' and initialize it with a positive value.
            int mynumber2 = 298311;

            // Declare integer variables to store the maximum and minimum integer values.
            int maxValue = int.MaxValue;
            int minValue = int.MinValue;

            // Print the values of 'mynumber', 'mynumber2', maximum, and minimum integer values to the console.
            Console.WriteLine("My number: " + mynumber);
            Console.WriteLine("My number 2: " + mynumber2);
            Console.WriteLine("Maximum value for int: " + maxValue);
            Console.WriteLine("Minimum value for int: " + minValue);
        }
    }
}
