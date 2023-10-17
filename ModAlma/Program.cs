using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulusOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // iki sayinin bölumunden kalani bulma methodudur.
            // % isareti ile islem yapilir 
            // Modulus operation finds the remainder when one number is divided by another.
            // It is performed using the '%' symbol.

            // Declare two integer variables, 'number1' and 'number2', and initialize them with values.
            int number1 = 10;
            int number2 = 3;

            // Perform the modulus operation to find the remainder when 'number1' is divided by 'number2'.
            // Store the result in the 'result' variable.
            int result = number1 % number2;

            // Print the result to the console.
            Console.WriteLine(result);
        }
    }
}



