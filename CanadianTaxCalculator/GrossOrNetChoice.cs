using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanadianTaxCalculator
{
    public static class GrossOrNetChoice
    {
        public static int GrossOrNetChoiceAnswer()
        {
            int grossOrNetChoice = 0;
            do
            {
                try
                {
                    
                    Console.Write("Press 1 to calculate Source Deductions and 2 to calculate Net to Gross amounts: ");

                    string grossOrNetChoiceText = Console.ReadLine();
                    grossOrNetChoice = int.Parse(grossOrNetChoiceText);

                    if (grossOrNetChoice != 1 && grossOrNetChoice != 2)
                    {
                        Console.WriteLine("Please enter a valid choice!");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid numerical value!");
                }
            }while (grossOrNetChoice != 1 && grossOrNetChoice != 2);

            return grossOrNetChoice;
        }

    }
}
