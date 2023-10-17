using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome message and available options
            int balance = 1000;
            Console.WriteLine("Welcome to the mini ATM");
            Console.WriteLine("1-Balance inquiry");
            Console.WriteLine("2-Withdrawal");
            Console.WriteLine("3-Deposit");
            Console.WriteLine("4-Quit");
            Console.WriteLine("10-naber lan ");
            Console.WriteLine("Please select the operation you want to perform");

            // Read user's choice
            string choosen = Console.ReadLine();


            switch (choosen)
            {
                case "10":
                    Console.WriteLine("Naber lan?=");
                    break;
                case "1":
                    Console.WriteLine("Balance: " + balance);
                    break;
                case "2":
                    // Prompt the user to enter withdrawal amount
                    Console.WriteLine("Enter the withdrawal amount: ");
                    int withdrawal = Convert.ToInt32(Console.ReadLine());

                    if (withdrawal > balance)
                    {
                        // Display "Insufficient balance" if the withdrawal amount exceeds the balance
                        Console.WriteLine("Insufficient balance");
                    }
                    else
                    {
                        // Calculate and display the remaining balance
                        balance -= withdrawal; // Update the balance
                        Console.WriteLine("Remaining balance: " + balance);
                    }
                    break;
                case "3":
                    // Prompt the user to enter deposit amount
                    Console.WriteLine("Enter the deposit amount: ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    balance += deposit; // Update the balance
                    Console.WriteLine("Updated balance: " + balance);
                    break;
                case "4":
                    Console.WriteLine("Thank you for using the mini ATM.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

            Console.ReadLine(); // This allows the user to see the output before the program exits.
        }
    }
}
