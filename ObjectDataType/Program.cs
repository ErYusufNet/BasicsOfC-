using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The object data type can hold values of any data type.
            // It is a versatile data type that can store various types of data.

            // Declare object variables and initialize them with different types of values.
            object value1 = "my object"; // A string value
            object value2 = 2;           // An integer value
            object value3 = 't';         // A character value
            object value4 = true;        // A boolean value

            // Print the values stored in object variables to the console.
            Console.WriteLine(value1); // Output: my object
            Console.WriteLine(value2); // Output: 2
            Console.WriteLine(value3); // Output: t
            Console.WriteLine(value4); // Output: True
        }
    }
}
