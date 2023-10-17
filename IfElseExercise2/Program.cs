using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome message and available options
            int balance = 1000;
            Console.WriteLine("Welcome to the mini ATM \r\n1-Balance inquiry\r\n2-Withdrawal\r\n3-Deposit\r\n4-Quit ");
            Console.WriteLine("Please select the operation you want to perform");

            // Read user's choice
            string choosen = Console.ReadLine();

            // Check user's choice and perform corresponding action
            if (choosen == "1")
            {
                // Display current balance
                Console.WriteLine("Your current balance is: " + balance);
            }
            else if (choosen == "2")
            {
                // Prompt the user to enter withdrawal amount
                Console.WriteLine("Enter the withdrawal amount: ");
                int withdrawal = Convert.ToInt32(Console.ReadLine());

                // Check if the withdrawal amount is greater than the balance
                if (withdrawal <= balance)
                {
                    // Calculate and display the remaining balance
                    Console.WriteLine("Remaining balance: " + (balance - withdrawal));
                }
                else
                {
                    // Display "Insufficient balance" if the withdrawal amount exceeds the balance
                    Console.WriteLine("Insufficient balance");
                }
            }
            else if (choosen == "3")
            {
                // Prompt the user to enter deposit amount
                Console.WriteLine("Enter the deposit amount: ");
                int deposit = Convert.ToInt32(Console.ReadLine());

                // Calculate and display the updated balance
                Console.WriteLine("Current balance: " + (balance + deposit));
            }
            else if (choosen == "4")
            {
                // Exit the program with a farewell message
                Console.WriteLine("Thank you, goodbye!");
            }
            else
            {
                // Display a message for invalid choices
                Console.WriteLine("Invalid choice. Please select a valid operation.");
            }
        }
    }
}
