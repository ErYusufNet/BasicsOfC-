using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessThanOrEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 33;
            bool control1 = number1 < 30;

            int number2 = 25;
            bool control2 = number2 < 30;

            int number3 = 30;
            bool control3 = number3 <= 30;

            // Print the results of comparisons to the console.
            Console.WriteLine(control1);
            Console.WriteLine(control2);
            Console.WriteLine(control3);
        }
    }
}
