using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Byte stores positive whole numbers between 0 and 255.
             * It occupies 1 byte of memory.
             */

            // Declare two byte variables, 'first' and 'second', and assign them values.
            byte first = 5;
            byte second = 25;
            byte maxValue = byte.MaxValue;
            byte minValue = byte.MinValue;
            Console.WriteLine(minValue);
            Console.WriteLine(maxValue);

            // Print the values of 'first' and 'second' to the console.
            Console.WriteLine("The value of 'first' is: " + first);
            Console.WriteLine("The value of 'second' is: " + second);

            // Print a message using the value of 'first'.
            Console.WriteLine("My favorite number is " + first);
        }
    }
}
