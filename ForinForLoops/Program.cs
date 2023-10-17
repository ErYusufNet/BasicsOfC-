using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForinForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                // Outer Loop (1): i increases from 1 to 10.
                for (int j = 1; j <= i; j++)
                {
                    // Inner Loop (2): j increases from 1 to i. In the nested loop, j increments based on the current value of the outer loop (i).

                    Console.Write(j); // Print the value of j to the screen. The value of j is printed on the screen during each iteration of the nested loop.
                }
                Console.WriteLine("");
                // When the inner loop is completed, a blank line is printed. This is done to move to a new line and start the pattern on the next line.
            }

            Console.ReadLine();
            // Awaits a key press to check the program's output and see the results.

         

        }
    }
}
