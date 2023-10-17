using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The short data type occupies 2 bytes (16 bits) of memory.
            // It can store integer values in the range of -32,768 to 32,767.

            // Declare a short variable 'firstVariable' and initialize it with a short integer value.
            short firstVariable = -50;

            // Print the value stored in the 'firstVariable' to the console.
            Console.WriteLine("My short value number is " + firstVariable);

            // Declare two short variables, 'MaxValue' and 'MinValue', to store the maximum and minimum possible short integer values.
            short MaxValue = short.MaxValue;
            short MinValue = short.MinValue;

            // Print the maximum and minimum short integer values to the console.
            Console.WriteLine("Maximum short value: " + MaxValue);
            Console.WriteLine("Minimum short value: " + MinValue);

            // Read a line from the console to keep the application running.
            Console.ReadLine();
        }
    }
}
