using System; // This line imports the System namespace, which contains core C# functionality.
using System.Collections.Generic; // This line imports the namespace for working with generic collections.
using System.Linq; // This line imports the LINQ namespace for querying collections.
using System.Text; // This line imports functionality for working with text and strings.
using System.Threading.Tasks; // This line imports the namespace for working with asynchronous programming.

namespace WhileLoops // This defines the namespace for your program.
{
    internal class Program // This is the main program class.
    {
        static void Main(string[] args) // This is the entry point for your program.
        {
            /*
            // Demonstrating a simple 'while' loop with incremental numbers.
            int b= 1; // Declare an integer variable 'a' and initialize it to 1.
            while (b<= 10) // Start a 'while' loop. It continues as long as 'a' is less than or equal to 10.
            {
                Console.WriteLine(b; // Print the value of 'a' to the console.
                b+; // Increment the value of 'a' by 1.
            }
            */

            // Demonstrating another 'while' loop with decreasing numbers.
            int a = 100; // Re-declare 'a' and initialize it to 100.
            while (a >= 0) // Start a new 'while' loop. It continues as long as 'a' is greater than or equal to 0.
            {
                Console.WriteLine(a); // Print the value of 'a' to the console.
                a -= 2; // Decrement the value of 'a' by 2.
            }
        }
    }
}
