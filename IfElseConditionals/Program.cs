using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Write a program which prints If student's exam grade is  higher than 80 " Pass " if it is lower than 80 than "Fail".

            Console.WriteLine("What is your exam grade? ");
            string grade = Console.ReadLine();
            int intGrade = int.Parse(grade);
            if (intGrade>80)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
    }
}
