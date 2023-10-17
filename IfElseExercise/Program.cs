using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get 3 grades from user and find the average of the grades
            // if grade's average is 80 - 100 write A
            //if grade's average is 60-80 write B
            //if grade's average is 40-60 write c
            //if grade's average less than 40 write fail

            Console.WriteLine("What is your first,second and third grade? : ");
            int first_grade = Convert.ToInt32(Console.ReadLine());
            int second_grade = Convert.ToInt32(Console.ReadLine());
            int third_grade = Convert.ToInt32(Console.ReadLine());
            int average = (first_grade + second_grade + third_grade) / 3;
            if(average> 80 && average<100)
            {
                Console.WriteLine("Your result is : A. Succesful you have passed the course ");
                Console.WriteLine("Your average point is : " + average);
            }
            else if(average> 60 && average< 80)
            {
                Console.WriteLine("Your result is : B. Succesful you have passed the course");
                Console.WriteLine("Your average point is : " + average);
            }
            else if (average>40 && average <60 )
            {
                Console.WriteLine("Your result is : C. Succesful you have passed the course");
                Console.WriteLine("Your average point is : " + average);
            }
            else 
            {
                Console.WriteLine("You have failed");
                Console.WriteLine("Your average point is : " + average);
            }
        }
    }
}
