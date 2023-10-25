using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            // Two ways to declare and initialize arrays:

            // First way is to declare an array with a specific size and then assign values to individual elements.

            int[] numbers = new int[4]; // Create an integer array named "numbers" that can hold 4 elements.

            numbers[0] = 10; // Assign the value 10 to the first element of the array.
            numbers[1] = 20; // Assign the value 20 to the second element of the array.
            numbers[2] = 30; // Assign the value 30 to the third element of the array.
            numbers[3] = 40; // Assign the value 40 to the fourth element of the array.

            for (int i = 0; i < numbers.Length; i++)
            {
                // Use a for loop to iterate through the elements of the "numbers" array and print each element.
                Console.WriteLine(numbers[i]);
            }

            // Second way is to declare and initialize an array directly.

            //Console.WriteLine(names[2]); // Print the third element of the "names" array (which is "Azure").
            string[] names = { "Python", "JavaScript", "Azure" }; // Create a string array named "names" with three elements.

            for (int i = 0; i < names.Length; i++)
            {
                // This is a for loop that iterates through the "names" array.
                // It initializes an integer variable "i" to 0 at the beginning.
                // The loop will continue as long as "i" is less than the length of the "names" array.
                // In this case, the length of the array is 3, so the loop will run for i = 0, i = 1, and i = 2.

                Console.WriteLine(names[i]);
                // Inside the loop, it uses the "i" variable to access elements of the "names" array.
                // It prints each element to the console. The "i" variable is used as the index to access the array.
                // So, it will print the elements in the "names" array one by one.
            }

            int[] numbers2 = numbers2 = new int[4];
            for(int i = 0; i<numbers2.Length; i++)
            {
                Console.Write("Sayilar2 dizisinin " + ( i + 1) + ". index degerini giriniz:");
                numbers2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("*************************");
            for (int i = 0; i < numbers2.Length; i++)
            { 
                Console.WriteLine(numbers2[i]);
            };
            Console.ReadLine();



        }
    }
}
