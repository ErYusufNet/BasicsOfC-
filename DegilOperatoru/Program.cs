using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegationOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Symbol: !
            // In short, it negates or reverses the existing value.

            // Declare a boolean variable 'a' and initialize it with the value 'true'.
            bool a = true;

            // Use the negation operator '!' to reverse the value of 'a'.
            // In this case, 'true' becomes 'false', and 'false' becomes 'true'.
            Console.WriteLine(!a);
        }
    }
}
