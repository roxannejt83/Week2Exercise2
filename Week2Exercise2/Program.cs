using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise2
{
    internal class SumOfDigits // Declares class that contains the main method where the execution starts
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number: "); // Prompt the user to enter an integer number
            int number = Convert.ToInt32(Console.ReadLine()); // Read the input from the user and convert it to an integer
            int sum = 0; // Initialze a variable to hold the sum of the digits
            // Use a while loop to process each digit of the number
            while (number != 0) // The loop continues untl the number is reduced to 0
            {
                int lastDigit = number % 10; // Use the modulus operator to get the last digit of the number
                sum += lastDigit; // Add the last digit to the sum
                number /= 10; // Use integer division to remove the last digit from the number
            }
            Console.Write("The sum of the digits is: " + sum + ".  Press 'Enter' to exit."); // Display the result to the user
            Console.ReadLine(); // Wait to close
        }
    }
}
