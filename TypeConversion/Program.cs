using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            // How to convert a data type to another data type ?
            int a = 1;
            byte b = (byte)a;
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            */
            /*
            // STRING TO INTEGER CONVERSION!
            string number1 = "1";
            string number2 = "2";
            int a = int.Parse(number1); // Parse. is the one type of converting the data to another data
            int b = int.Parse(number2);
            Console.WriteLine(a+b); 
            
            string number1 = "1";
            string number2 = "2";
            int a = Convert.ToInt32(number1); // To.Int32 is the one type of converting data to another data
            int b = Convert.ToInt32(number2);
            */

            /*
            // INTEGER TO STRING CONVERSION!
            int number1 = 5;
            int number2 = 7;

            // Converting integers to strings
            string a = number1.ToString();
            string b = number2.ToString();

            // When we add two integers, it performs normal mathematical addition.
            // when we add two strings, it concatenates them side by side.
            // In this case, we are adding two strings, 'a' and 'b'.
            // So, the result will be "57" because the strings are combined.
            Console.WriteLine(a + b);
            */


            // DOUBLE TO INTEGER CONVERSION
            /*
            double number = 5.22;
            int a = Convert.ToInt32(number); // with Convert.ToInt32 we do the conversion from double to int
            Console.WriteLine(a);
            Console.WriteLine(number.GetType());
            Console.ReadLine();
            */

            /*
            //The values which we get with input from user is in string data tpye
            // How to convert that to int?
            Console.WriteLine("How old are you? ");
            string age = Console.ReadLine();
            int userAge = int.Parse(age);
            int userAge2 = Convert.ToInt32(age);
            Console.WriteLine(userAge.GetType());
            Console.WriteLine(userAge);
            Console.WriteLine(userAge2);
            */

            //EXERCISE :Write a program that takes two numbers from the user and displays their sum on the screen
            /*
            Console.WriteLine("Give me the first number ");
            string number1 = Console.ReadLine();
            Console.WriteLine("Give me the second number");
            string number2 = Console.ReadLine();
            int IntNumber1 = int.Parse(number1);
            int IntNumber2 = Convert.ToInt32(number2);
            int sum = (IntNumber1 + IntNumber2);
            Console.WriteLine(IntNumber1.GetType());
            Console.WriteLine("The result of the sum of two numbers is : " +sum );
            */

            /*
             ToString();
             Convert.ToInt32();
             int.Parse();
             double.Parse();
             (int)

            */






        }
    }
}
