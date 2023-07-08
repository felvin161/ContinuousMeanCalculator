using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinuousMeanCalculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            int count = 0;     // Number of values entered
            double mean = 0;    // Sum of all values entered

            Console.WriteLine("Continuous Mean Value Calculator");
            Console.WriteLine(" Please Enter numbers or enter 'x' to exit");

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "x")
                    break;

                if (double.TryParse(input, out double value))
                {                 
                    count++;
                    mean = ((mean * (count - 1)) + value) / count;
                    Console.WriteLine("Mean: " + mean);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number or 'x' to exit.");
                }
            }

            Console.WriteLine("Program terminated.");
        }
    }
}
