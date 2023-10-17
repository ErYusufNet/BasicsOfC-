using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             The long data type is used for storing large integer values.
             The long data type occupies 8 bytes (64 bits), allowing it to represent extremely large integer values.

             The long data type can store integers within the range of -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
             This vast range is particularly useful for applications dealing with timestamps, unique identifiers, and large numbers.
             */

            // Declare a long variable 'mynumber' and initialize it with a large integer value.
            long mynumber = 30830443292;

            // Declare long variables to store the maximum and minimum possible long integer values.
            long maxValue = long.MaxValue;
            long minValue = long.MinValue;

            // Print the value of 'mynumber', as well as the maximum and minimum long integer values to the console.
            Console.WriteLine("My number: " + mynumber);
            Console.WriteLine("Maximum value for long: " + maxValue);
            Console.WriteLine("Minimum value for long: " + minValue);
        }
    }
}
