using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a for loop that iterates from 1 to 10.
            // 1'den 10'a kadar dönen bir for döngüsünü başlat.
            for (int i = 1; i <= 10; i++)
            {
                // Outer loop: This loop increments an integer variable named 'i' from 1 to 10.

                // Initialize an inner for loop that also iterates from 1 to 10.
                // Yine 1'den 10'a kadar dönen bir iç içe geçmiş for döngüsünü başlat.
                for (int j = 1; j <= 10; j++)
                {
                    // Nested loop: This loop increments an integer variable named 'j' from 1 to 10.

                    // Print the product of 'i' and 'j' in the format "ixj=result" to the console.
                    // "ixj=sonuç" biçiminde 'i' ve 'j' değişkenlerinin çarpım sonucunu ekrana yazdır.
                    Console.WriteLine(i + "x" + j + "=" + (i * j));
                }
            }
            // Read a line of input to prevent the console window from closing immediately.
            // Konsol penceresinin hemen kapanmasını önlemek için bir giriş satırını oku.
            Console.ReadLine();
        }
    }
}
