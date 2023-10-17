using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to coding with C#");
            string welcome = Console.ReadLine();
            Console.WriteLine("What is your name? : ");
            string name = Console.ReadLine();
            
            Console.WriteLine("What is your surname= : ");
            string surname = Console.ReadLine();
            
            // Prompt the user to enter their age and store the input in a string using 'Console.ReadLine()'.
            Console.WriteLine("How old are you? ");

            // Read the user's input as a string, and then use 'int.Parse()' to convert it into an integer.
            // This allows us to safely convert the string input to an integer data type.
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine("Your name is " + name + " surname is " + surname + " you are " + age + " years old.");
            Console.ReadLine();
            
        }
    }
}
