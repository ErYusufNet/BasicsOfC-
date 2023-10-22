using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Break and continue
             for(int a = 1; a<=10; a++)
            {
                if (a == 7)
                {
                    break;
                }
                Console.WriteLine("A's value is : " + a);
            }
             Console.ReadLine();
        }
    }
}
