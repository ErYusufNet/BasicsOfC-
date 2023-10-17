using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Assignment Operators:
             +=
             -=
             /=
             *=
            */

            // Example 1: +=
            int a = 5;
            // Define an integer variable 'a' and assign it the value 5.

            a += 1;
            // Add 1 to 'a' using the 'a += 1' shorthand and assign the result back to 'a'.

            Console.WriteLine("+= Example: " + a);
            // Print the value of 'a'. The result will be 6.

            // Example 2: -=
            int b = 10;
            // Define an integer variable 'b' and assign it the value 10.

            b -= 3;
            // Subtract 3 from 'b' using the 'b -= 3' shorthand and assign the result back to 'b'.

            Console.WriteLine("-= Example: " + b);
            // Print the value of 'b'. The result will be 7.

            // Example 3: /=
            double c = 20.0;
            // Define a double variable 'c' and assign it the value 20.0.

            c /= 4;
            // Divide 'c' by 4 using the 'c /= 4' shorthand and assign the result back to 'c'.

            Console.WriteLine("/= Example: " + c);
            // Print the value of 'c'. The result will be 5.0 (double division).

            // Example 4: *=
            int d = 6;
            // Define an integer variable 'd' and assign it the value 6.

            d *= 2;
            // Multiply 'd' by 2 using the 'd *= 2' shorthand and assign the result back to 'd'.

            Console.WriteLine("*= Example: " + d);
            // Print the value of 'd'. The result will be 12.
        }
    }
}
