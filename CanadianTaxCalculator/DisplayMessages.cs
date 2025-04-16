using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanadianTaxCalculator
{
    public static class DisplayMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("**************** Welcome to Canadian Tax Calculator V1.0 (by Ryan Raynal) ****************");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("This app was designed to calculate Canadian Source Deductions or Net to Gross amounts.");
            Console.WriteLine("All calculations are based on the CRA's rates for 2025.");
            Console.WriteLine(" ");
        }
        public static void GoodbyeMessage()
        {
            Console.WriteLine(" ");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("******************** Thank you for having used Canadian Tax Calculator *******************");
            Console.WriteLine("******************************************************************************************");
        }
        public static void ErrorMessageInvalidNumber()
        {
            Console.WriteLine("Please enter a valid number!");
        }
        public static void ErrorMessageInvalidNumericalValue()
        {
            Console.WriteLine("Please enter a numerical value!");
        }
        public static void ErrorMessageInvalidWord()
        {
            Console.WriteLine("Please enter a valid word!");
        }
    }
}
