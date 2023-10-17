using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String data type is used to store text and character data.

            // Declare string variables 'name' and 'surname' and an integer variable 'age'.
            string name = "Yusuf";
            string surname = "Er";
            int age = 26;

            // Create a string 'result' by concatenating the variables to form a sentence.
            string result = "My name is " + name + " and surname is " + surname + " and I am " + age.ToString() + " years old.";

            // Create another string 'result2' using string formatting.
            string result2 = string.Format("My name is {0} and surname is {1} and I am {2} years old.", name, surname, age);

            // Print the results to the console.
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
