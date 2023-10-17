using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Occupies 8 bytes of memory
                Holds decimal numbers with up to 15 digits
                Can represent negative numbers as well
                We provide comments that describe the double data type:
                double occupies 8 bytes of memory, making it capable of storing larger values with greater precision compared to float.
                It can hold decimal numbers with up to 15 significant digits.
                double can represent both positive and negative numbers, making it suitable for a wide range of numeric values.
                The double data type is commonly used in C# for working with decimal numbers 
                that require a high degree of precision. It's suitable for a wide range of 
                mathematical and scientific calculations. Here are a few examples of how double can be used:
              */
            double pi = 3.141592653589793;
            double temperature = 98.6;
            double distance = 12345.6789;

            double result = 10.0 / 3.0; // Stores the result of a division operation with decimal values

        }
    }
}
