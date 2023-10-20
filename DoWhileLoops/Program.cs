using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Write a program that prints numbers from 1 to 10 with a do-while loop.

            int a = 1; // Declare an integer variable 'a' and initialize it with the value 1.

            do // Start a do-while loop. It executes the code block at least once before checking the condition.
            {
                Console.WriteLine(a); // Print the current value of 'a' to the console.
                a++; // Increment the value of 'a' by 1.

            } while (a <= 10); // Check if 'a' is less than or equal to 10. If true, continue the loop. If false, exit the loop.

            Console.ReadLine(); // Wait for the user to press Enter before closing the console window.
            */
            int b = 1;
            int toplam = 0;
            do
            {
                toplam += b;
                b++;

            } while (b <= 100);
            Console.WriteLine(toplam);
            Console.ReadLine();
        }
            
    }
}

