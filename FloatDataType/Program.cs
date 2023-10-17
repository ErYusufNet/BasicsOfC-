using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             The float data type occupies 4 bytes (32 bits) of memory
             and can represent approximately 7.8 significant decimal digits.
             Float values are defined with a literal ending in 'f' or 'F'.
             */

            // Declare a float variable 'mynumber' and initialize it with the value 3.456f.
            float mynumber = 3.456f;

            // Declare float variables to store the maximum and minimum float values.
            float maxValue = float.MaxValue;
            float minValue = float.MinValue;

            // Print the minimum and maximum values of the float data type.
            Console.WriteLine("Minimum value for float: " + minValue);
            Console.WriteLine("Maximum value for float: " + maxValue);

            // Print the value of 'mynumber'.
            Console.WriteLine("My float number is: " + mynumber);
        }
    }
}
